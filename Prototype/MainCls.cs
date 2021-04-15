using System;

namespace Prototype
{
    public class MainCls
    {
        static void Main()
        {
            BookLib lib = new BookLib();
            lib.SetLibraryName("ALib");
            lib.LoadBooks();

            BookLib lib2 = lib.Clone();// Cloning from prev copy instead of getting from database
        }
        
       
    }
}
