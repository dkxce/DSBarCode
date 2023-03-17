# DSBarCode

BarCode Generator

DSBarCode.BarCodeCtrl ctrl = new DSBarCode.BarCodeCtrl();   
ctrl.ShowFooter = false;   
ctrl.ShowHeader = false;			   
ctrl.BarCodeHeight = 40;   
ctrl.Width = 500;   
ctrl.Height = 60;   
ctrl.BarCode = "13456789";   
ctrl.SaveImage("c:\\Downloads\\test.bmp");   
