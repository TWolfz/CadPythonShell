﻿using Autodesk.AutoCAD.Runtime;

namespace CADPythonShell
{
    public class SnoopCommand : ICadCommand
    {
        [CommandMethod("Snoop")]
        public override void Execute()
        {
           new CADSnoop.SnoopCommand().Snoop();
        }
    }
}
