//----------------------------------------------------------------------------
//  Copyright (C) 2004-2012 by EMGU. All rights reserved.       
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Emgu.CV;
using Emgu.CV.Structure;

namespace HelloWorld
{
   public class Application
   {
      // This is the main entry point of the application.
      static void Main(string[] args)
      {
         // if you want to use a different Application Delegate class from "AppDelegate"
         // you can specify it here.
         UIApplication.Main(args, null, "AppDelegate");
      }
   }
}
