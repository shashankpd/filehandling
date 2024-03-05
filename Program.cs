/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;


internal class Program
    {
        static void Main(string[] args)
        {
        string filepath = "E:\\newfile.txt";

        try
        {
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine("my name is shashank");
                sw.WriteLine("hello everyone");
            }
            Console.WriteLine("file written successfully");
        }
        catch (IOException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        }
    }*/

/*using System;
using System.IO;
using System.Runtime.CompilerServices;

public class flread
{
    public static void Main(string[] args)
    {
        string path= "E:\\newfile.txt";
        try 
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }   
    }
}
*/

//creating file 2

/*using System;
using System.IO;

public class wrtfl2
{
    public static void Main(string[] args)
    {
        string filepath2= "E:\\newfile2.txt";

        try
        {
            using (StreamWriter swr = new StreamWriter(filepath2))
            {
                swr.WriteLine("i am merging this file with the other file");
                swr.WriteLine(" work with it");

            }
            Console.WriteLine("successfully written file2");
        }
        catch (IOException ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
}*/

//merging 2 files in another

/*using System;
using System.IO;

public class fileMerge
{
    public static void Main(string[] args)
    {
        string filepath1 = "E:\\newfile.txt";
        string filepath2 = "E:\\newfile2.txt";
        string merge = "E:\\mergefile.txt";

        try
        {
            using (StreamReader sr1 = new StreamReader(filepath1))
            {
                using (StreamReader sr2 = new StreamReader(filepath2))

                {
                    using (StreamWriter swm = new StreamWriter(merge))
                    {
                        string line;
                        while ((line = sr1.ReadLine()) != null)
                        {
                            swm.WriteLine(line);
                        }
                        while ((line = sr2.ReadLine()) != null)
                        {
                            swm.WriteLine(line);
                        }
                    }
                }
            }
            Console.WriteLine("file merged successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
*/

/*using System;
using System.IO;

public class Rnam
{
    public static void Main(string[] args)
    {
        try
        {
            File.Move("E:\\newfile.txt", "E:\\newfile1.txt");
            Console.WriteLine("sucessfully Renamed");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}*/

//writing to the existing file

/*using System;
using System.IO;
public class writingtoexistingfile
{
    public static void Main(string[] args)
    {
        string pathEx = "E:\\newfile1.txt";
       
        try
        {
            using (StreamWriter swe = new StreamWriter(pathEx))
            {
                swe.WriteLine("writing this to existing file");
            }
            Console.WriteLine("sucessfully added");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}*/

/*using System;
using System.IO;
public class writingtoexistingfile
{
    public static void Main(string[] args)
    {
        string pathEx = "E:\\newfile1.txt";

        try
        {
            using (StreamWriter swe = File.AppendText(pathEx))
            {
                swe.WriteLine("writing this to existing file .........");
            }
            Console.WriteLine("sucessfully added");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}*/


//writing to csv file

/*using System;
using System.IO;
public class csvfil
{
    public static void Main(string[] args)
    {
        string path= "E:\\newfile1.csv";

        using (StreamWriter cs = new StreamWriter(path))
        {
            cs.WriteLine("Name,age,city");
            cs.WriteLine("Shashank,24 ,banglore ");
            cs.WriteLine("harsha,25 ,Mysore ");
        }
        Console.WriteLine("successfully added");
    }
}*/

/*using System;
using System.IO;
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public class pdfcreate
{
    static void Main(string[] args)
    {
        string path= "E:\\newfile1.pdf";

        try
        {
            using (PdfWriter pdf = new PdfWriter(path))
            {
                using (PdfDocument document = new PdfDocument(pdf))
                {
                    Document doc = new Document(document);

                    doc.Add(new Paragraph("hello pdf i am pdf"));
                }
            }
            Console.WriteLine("sucessfully created");
        }

        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (pdfException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}*/

//checking existing file

/*using System;
using System.IO;
public class exist
{
    public static void Main(string[] args)
    {
        string path = "E:\\newfle1.pdf";
        if (File.Exists(path))
        {
            Console.WriteLine("file exists");
        }
        else
        {
            Console.WriteLine("there is no such file");
        }
    }
}*/

//Adding Dictionaries to the csv file

/*using System;
using System.Collections.Generic;
using System.IO;

public class diccsv
{
    public static void Main(string[] args)
    {
        string Path = "E:\\csvfile.csv";


        Dictionary<string,string> info= new Dictionary<string,string>();
        info.Add("Name", "shashank");
        info.Add("Age", "24");
        info.Add("City", "Banglore");

        try
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine("key,value");

                foreach (var item in info)
                {
                    sw.WriteLine(item);
                }
            }
            Console.WriteLine("sucessfully added to csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}*/

//reading csv files 

/*using System;
using System.IO;

public class readcsv
{
    public static void Main(string[] args)
    {

        string path= "E:\\csvfile.csv";
        try
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("sucess");
            }
        }
        catch(IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
*/
using System;
using System.IO;

public class copying    
{
    public static void Main(string[] args)
    {
       string path1= "E:\\newfile1.txt";
        string path2= "E:\\newfile3.txt";

        try
        { 
         File.Copy(path1, path2);
            Console.WriteLine("copied sucessfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}