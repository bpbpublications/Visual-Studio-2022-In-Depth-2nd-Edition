using System;

namespace PackageValidation_Ex
{
    public class Class1
    {
#if NET6_0_OR_GREATER
    public void MethodThatWorksInNET6AndABOVE()
    {
            // Do something.
    }
#endif
        public void MethodThatDOESNTWorkInNET6AndABOVE(string input)
        {
            // Do something.
        }
    }
}
