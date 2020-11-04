using Asta_import.Properties;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Asta_import
{
    class ListConverter
    {

        public delegate void ProgressUpdate(string statusMsg);
        public event ProgressUpdate OnProgressUpdate;

        public List<Registrering> stykkList = new List<Registrering>();
        public List<Registrering> mappeList = new List<Registrering>();


        public void ConvertList(string inFileName, string outFileName)
        {
            stykkList.Clear();
            mappeList.Clear();

            try
            {
                ReadInList(inFileName);

                if (stykkList.Count > 0)
                    WriteOutList(outFileName);
            }catch(Exception e)
            {
                OnProgressUpdate?.Invoke("ERROR: " + e.Message);
                throw e;
            }
        }

        public void ReadInList(string fileName)
        {
            Console.WriteLine("Leser innfil: " + fileName);

            Application xlApp = new Application();

            Workbook inWorkBook = xlApp.Workbooks.Open(fileName);

            Worksheet inSheet = inWorkBook.Sheets[1];

            Range inRange = inSheet.UsedRange;
            try
            {

                string arkID = GetTextValue(7, 2, inRange);
                string serie1ID = GetTextValue(8, 2, inRange); 
                string serie2ID = GetTextValue(9, 2, inRange); 
                string serie3ID = GetTextValue(10, 2, inRange);

                int rowCount = inRange.Rows.Count;

                string stykkeID = String.Empty;

                for (int i = 13; i <= rowCount; i++)
                {
                    OnProgressUpdate?.Invoke("Leser rad: " + i);

                    if (inRange.Cells[i, 1].Value2 == null && inRange.Cells[i, 8].Value2 == null)
                        continue;

                    if (inRange.Cells[i, 1] != null && inRange.Cells[i, 1].Value2 != null)
                    {
                      //  Console.WriteLine("Row: " + i);

                        stykkeID = 'L' + GetTextValue(i, 1, inRange);
                        //Console.WriteLine("Nytt stykke: " + stykkeID);
                        Registrering stykke = new Registrering();
                        stykke.Path = MakeRegPath(arkID, serie1ID, serie2ID, serie3ID);
                        //stykke.Path = arkID + '/' + serie1ID + '/' + serie2ID + '/' + serie3ID + '/';

                        stykke.RegID = stykkeID;

                        stykke.RegName = GetTextValue(i, 2, inRange);
                        stykke.StartDate = GetValue(i, 3, inRange);
                        stykke.EndDate = GetValue(i, 4, inRange);
                        stykke.StartCode = GetTextValue(i, 5, inRange);
                        stykke.EndCode = GetTextValue(i, 6, inRange);

                        stykke.Merknad = GetTextValue(i, 7, inRange);

                        stykkList.Add(stykke);

                       // Console.WriteLine(stykke.RegName + " lagt til i stykkelist");
                    }

                    if (inRange.Cells[i, 8] != null && inRange.Cells[i, 8].Value2 != null)
                    {
                        //Console.WriteLine("Ny mappe");

                        Registrering mappe = new Registrering();
                        mappe.Path = MakeRegPath(arkID, serie1ID, serie2ID, serie3ID) + stykkeID + '/';


                        mappe.RegID = GetTextValue(i, 8, inRange);

                        mappe.RegName = GetTextValue(i, 9, inRange);
                        mappe.StartDate = GetValue(i, 10, inRange);
                        mappe.EndDate = GetValue(i, 11, inRange);
                        mappe.StartCode = GetTextValue(i, 12, inRange);
                        mappe.EndCode = GetTextValue(i, 13, inRange);

                        mappe.Merknad = GetTextValue(i, 14, inRange);

                        mappeList.Add(mappe);

                       // Console.WriteLine(mappe.RegName + " lagt til i mappelist");

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("UNNTAK: " + e.Message);
                throw e;
            }
            finally
            {

                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(inRange);
                Marshal.ReleaseComObject(inSheet);

                inWorkBook.Close();
                Marshal.ReleaseComObject(inWorkBook);

                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
        }

        public void WriteOutList(string outFileName)
        {
            Application xlApp = new Application();

            DirectoryInfo dirInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            String temp = dirInfo.FullName;
            string protokollTemplate = Path.Combine(temp, "Resources", "Koblingsprotokoll_template.xlsx");

            Workbook outWorkBook = xlApp.Workbooks.Open(protokollTemplate);

            //Workbook outWorkBook = xlApp.Workbooks.Add(Missing.Value);

            Worksheet outSheet = outWorkBook.Sheets[1];

            Range outRange = outSheet.UsedRange;

            int unitID = 1001;

            int i = 2;
            foreach (Registrering stykke in stykkList)
            {
                OnProgressUpdate?.Invoke("Skriver stykke: " + stykke.RegID);

                outRange.Cells[i, 1].Value2 = 1008;

                outRange.Cells[i, 2].Value2 = stykke.Path;
                outRange.Cells[i, 3].Value2 = stykke.RegID;
                outRange.Cells[i, 4].Value2 = stykke.RegName;

                outRange.Cells[i, 6].Value2 = stykke.StartDate;
                outRange.Cells[i, 7].Value2 = stykke.EndDate;

                outRange.Cells[i, 8].Value2 = stykke.StartCode;
                outRange.Cells[i, 9].Value2 = stykke.EndCode;

                outRange.Cells[i, 10].Value2 = stykke.Merknad;

                outRange.Cells[i, 18].Value2 = unitID;

                outRange.Cells[i, 11].Value2 = Settings.Default.komNavn;
                outRange.Cells[i, 14].Value2 = Settings.Default.fylkeNr;
                outRange.Cells[i, 15].Value2 = Settings.Default.landKode;
                outRange.Cells[i, 16].Value2 = Settings.Default.depInst;

                i++;
                unitID++;
            }

            foreach (Registrering mappe in mappeList)
            {
                OnProgressUpdate?.Invoke("Skriver mappe: " + mappe.RegID);

                outRange.Cells[i, 1].Value2 = 1002;

                outRange.Cells[i, 2].Value2 = mappe.Path;
                outRange.Cells[i, 3].Value2 = mappe.RegID;
                outRange.Cells[i, 4].Value2 = mappe.RegName;

                outRange.Cells[i, 6].Value2 = mappe.StartDate;
                outRange.Cells[i, 7].Value2 = mappe.EndDate;

                outRange.Cells[i, 8].Value2 = mappe.StartCode;
                outRange.Cells[i, 9].Value2 = mappe.EndCode;

                outRange.Cells[i, 10].Value2 = mappe.Merknad;

                outRange.Cells[i, 18].Value2 = unitID;

                outRange.Cells[i, 11].Value2 = Settings.Default.komNavn;
                outRange.Cells[i, 14].Value2 = Settings.Default.fylkeNr;
                outRange.Cells[i, 15].Value2 = Settings.Default.landKode;
                outRange.Cells[i, 16].Value2 = Settings.Default.depInst;

                i++;
                unitID++;
            }

            outWorkBook.SaveAs(outFileName);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(outRange);
            Marshal.ReleaseComObject(outSheet);

            outWorkBook.Close();
            Marshal.ReleaseComObject(outWorkBook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private string GetValue(int row, int col, Range range)
        {
            if (range.Cells[row, col] != null && range.Cells[row, col].Value2 != null)
                return range.Cells[row, col].Value2.ToString();
            else
                return "";
        }

        private string GetTextValue(int row, int col, Range range)
        {
            if (range.Cells[row, col] != null && range.Cells[row, col].Value2 != null)
                return range.Cells[row, col].Text.Trim();
            else
                return "";
        }


        private string MakeRegPath(string AId, string S1, string S2, string S3)
        {
            string path = AId;
            if (String.IsNullOrEmpty(S3))
            {
                path = AId + '/' + S1 + '/' + S2 + '/';
            }
            else if (String.IsNullOrEmpty(S2))
            {
                path = AId + '/' + S1 + '/';
            }
            else
            {
                path = AId + '/' + S1 + '/' + S2 + '/' + S3 + '/';
            }

            return path;
        }
    }

    public class Registrering
    {
        public string Path { get; set; }
        public string RegName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StartCode { get; set; }
        public string EndCode { get; set; }
        public string RegID { get; set; }
        public string Merknad { get; set; }

    }
}
