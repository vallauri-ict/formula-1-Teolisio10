using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormulaOneDll;

namespace FormulaOneBatchConsoleProject
{
    class Program
    {
        static DbTools db = new DbTools();

        static void Main(string[] args)
        {
            char scelta = ' ';
            do
            {
                Console.WriteLine("\n*** FORMULA ONE - BATCH SCRIPTS ***");
                Console.WriteLine("1 - Create Countries");
                Console.WriteLine("2 - Create Drivers");
                Console.WriteLine("3 - Create Teams");
                Console.WriteLine("------------------");
                /*Console.WriteLine("4 - Insert Countries");
                Console.WriteLine("5 - Insert Teams");
                Console.WriteLine("6 - Insert Drivers");
                Console.WriteLine("------------------");*/
                /*Console.WriteLine("7 - Read Countries");
                Console.WriteLine("8 - Read Teams");
                Console.WriteLine("9 - Read Drivers");
                Console.WriteLine("------------------");*/
                Console.WriteLine("a - Drop Teams");
                Console.WriteLine("b - Drop Drivers");
                Console.WriteLine("c - Drop Countries");
                Console.WriteLine("------------------");
                /*Console.WriteLine("d - Update Countries");
                Console.WriteLine("e - Update Teams");
                Console.WriteLine("f - Update Drivers");
                Console.WriteLine("------------------");*/
                Console.WriteLine("r - Reset Table");
                Console.WriteLine("------------------");
                Console.WriteLine("X - EXIT\n");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case '1': callExecuteSqlScript("Countries");    break;
                    case '2': callExecuteSqlScript("Drivers");      break;
                    case '3': callExecuteSqlScript("Teams");        break;
                    case 'a': callDropTable("Teams");               break;
                    case 'b': callDropTable("Drivers");             break;
                    case 'c': callDropTable("Countries");           break;
                    case 'r': resetDB();                            break;
                    default: Console.WriteLine("\n\tUncorrect Choice - Try Again\n"); break;
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        static bool callExecuteSqlScript(string scriptName)
        {
            try
            {
                db.ExecuteSqlScript(scriptName + ".sql");
                Console.WriteLine("Create " + scriptName + " - SUCCESS\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create " + scriptName + " - ERROR: " + ex.Message + "\n");
                return false;
            }
        }

        static bool callDropTable(string tableName)
        {
            try
            {
                db.DropTable(tableName);
                Console.WriteLine("DROP " + tableName + " - SUCCESS\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DROP " + tableName + " - ERROR: " + ex.Message + "\n");
                return false;
            }
        }

        private static void resetDB()
        {
            Console.WriteLine("\tWARNING!!! The script will completely destroy and recreate the DB! Are you sure (s/n)");
            char answer = Console.ReadKey(true).KeyChar;
            if(answer == 's' || answer == 'S')
            {
                try
                {
                    // creare copia backup
                    // db.backupDB();
                    bool isOk;
                    isOk = callDropTable("Teams");
                    if (isOk) isOk = callDropTable("Drivers");
                    if (isOk) isOk = callDropTable("Countries");
                    if (isOk) isOk = callExecuteSqlScript("Countries");
                    if (isOk) isOk = callExecuteSqlScript("Drivers");
                    if (isOk) isOk = callExecuteSqlScript("Teams");
                    if (isOk) isOk = callExecuteSqlScript("setConstraints");
                    if (isOk)
                        Console.WriteLine("\tDB correctly resetted!\n");
                    else
                        throw new Exception();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\tSorry, something went wrong!\n");
                    Console.WriteLine(ex.Message);
                    // ripristinare versione backup
                }
            }
        }
    }
}
