//in C#, input ,output is done by using stream. Stream is a sequence of byte. To write on a file stringWriter class is used to read from a file StreamReader class is used 
using System;
using System.IO; //file handling
class FileHandlingDemo{
    public void writeFile(){
        //take any string input from user and write to a file 
        StreamWriter sw=new StreamWriter("/Desktop/DotNet/Chapter1/7_FileHandlin/b.txt");
                                        
        Console.WriteLine("Enter line of text");
        string data=Console.ReadLine();
        sw.WriteLine(data);
        sw.Flush();
        sw.Close();
    }
    //reading from the file
    public void readFile(){
StreamReader sr=new StreamReader("/Desktop/DotNet/Chapter1/7_FileHandlin/b.txt");
string ans;
while((ans=sr.ReadLine())!=null){
    Console.Write(ans);
}
sr.Close();


    }
}