// insert command in ExampleFla.fla
// #include "JSSwiffy.as"
// ActionScript 2.0
var CurMovie:String = "0";
var CurField:String = "0";
var CountParams:Number = 0;
var GetResFunc:String = "";

GetStatus=function()
{
	return "";
}

SetGotoAndStop = function(value){
	eval(CurMovie).gotoAndStop(value);	
}
addProperty("GotoAndStop",GetStatus,SetGotoAndStop);

// Run any function 
// value is string like "1;;2;;3" where ";;" splits params
// Max count params for func is 6
SetRunFunc = function(value){
	if(curField!="0"){
		var arr:Array = new Array(6); 
		arr = value.split(";;"); 
				
        GetResFunc = 
		eval((CurMovie!="0")? CurMovie+"."+String(CurField) : String(CurField))
		(arr[0],arr[1],arr[2], arr[3],arr[4],arr[5]);	


		//Text1.text = CurMovie;
		//Text2.text = CurField;
		//trace(GetResFunc);
		//trace("cm="+CurMovie + " cf=" + CurField);
	}		
}
addProperty("RunFunc",GetStatus,SetRunFunc);


SetSetVar = function(value){	
     if(curField!="0"){
		 if(CurMovie!="0")
			_root[CurMovie][CurField] = value;
		 else
			_root[CurField] = value;		 		 
	 }
}
addProperty("SetVar",GetStatus,SetSetVar);

// Receive Value 
// if param = 1 result= CurMovie.CurField
// else result= CurField
SetGetData = function(value){
	//flash.external.ExternalInterface.call("jsFunction", "Hello");
	if( value== "1")
		_root.getURL("javascript:ReceiveDataFromAS('"+ _root[CurMovie][CurField] +"');"); 
	else
		_root.getURL("javascript:ReceiveDataFromAS('"+_root[CurField]+"');");
		//_root.getURL("javascript:ReceiveDataFromAS("+ _root[CurField] +");");
}
addProperty("GetData",GetStatus,SetGetData);
// Создаем мувиклип-родитель для контейнера
//trace (this.createEmptyMovieClip("logo_mc1", this.getNextHighestDepth()));
// Создаем контейнер внутри "mc_1"
// в этот мувиклип будет загружено изображение
//logo_mc.createEmptyMovieClip("container_mc",0);
//logo_mc.container_mc.loadMovie("http://www.macromedia.com/images/shared/product_boxes/80x92/studio_flashpro.jpg");


//CurMovie = "0";
//GotoAndStop = 1;
//CurMovie = "MovieClip1";
//CurField = "createEmptyMovieClip";
//GetData = 1;
//SetVar = 0;
//CountParamFunc = 2;
//curField = "gotoAndStop";
//curField = "stop";
//curField = "Func";
//RunFunc = "logo_mc;;"+this.getNextHighestDepth();


