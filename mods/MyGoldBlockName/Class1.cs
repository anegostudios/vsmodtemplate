using System;
using Vintagestory.API.Common;

namespace ClassLibrary1
{
    
    public class MyTestMod : ModBase
    {

        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            Console.Write("It works and can be debugged!");
        }
    }

}
