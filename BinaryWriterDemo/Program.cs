using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryWriter bw = null;
            BinaryReader br;

            try
            {
                //bw = new BinaryWriter(new FileStream("C:\\vidobu\\data", FileMode.Append));
                
                //bw.Write("BinaryWriter ile yazılan data\n");
                //bw.Write(DateTime.Now.ToString());

                br = new BinaryReader(new FileStream("c:\\vidobu\\data", FileMode.Open));

                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (bw != null)
                {
                    bw.Close();
                    bw.Dispose();
                }
            }
            Console.ReadKey();
        }
    }
}
