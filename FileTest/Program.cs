using System;
using System.Text;
using System.IO;
using System.Collections;


namespace FileTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Long Kanji Filename Test");
			string name = "";
			int iter=0;
			ArrayList names = new ArrayList ();
			try
			{
				for (iter=1; iter<1000; ++iter) {
				name += "字";
                File.WriteAllText(name, "");//create blank txt file
                names.Add(name);
				}
			}
			catch(Exception E) {
                //clearing all files
                for (int i = 0; i < names.Count; ++i)
                {
                    File.Delete((string)names[i]);
                }
				//report
                Console.WriteLine ("...");
				Console.WriteLine ("Last 5 entries...");
				for (int i=4; i>=0; --i) {
					int last = names.Count - 1;
					int ind = last - i;
					string str = (string)names [ind];
					Console.WriteLine ("Kanj: {0}", str.Length);
				}
				Console.WriteLine("OS: {0}",System.Environment.OSVersion);
				string[] data=E.Message.Split(new char[]{'.'},StringSplitOptions.RemoveEmptyEntries);
				Console.WriteLine("Kanji in filename: {0}\nError: {1}\n", iter, data[0]);
			}
		}
	}
}
