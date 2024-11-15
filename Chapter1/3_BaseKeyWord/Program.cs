namespace Untitled_Folder;

class Program
{
    static void Main(string[] args)
    {
     Solution s1=new Solution();
     Solution s2=new Solution(15,5,20,30);
     s2.calcSum();//parent method
     s2.calcDiff();
    }
}
