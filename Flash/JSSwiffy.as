// insert command in ExampleFla.fla
// #include "JSSwiffy.as"
// ActionScript 2.0
var CurMovie:String = "0";
var CurField:String = "0";
var CountParams:Number = 0;
var GetResFunc;

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
// Max count params for func is 5
SetRunFunc = function(value){
	if(curField!="0"){
		var arr:Array = new Array(5); 
		arr = value.split(";;"); 
        GetResFunc = 
		eval((CurMovie!="0")? CurMovie+"."+curField : curField)
		(arr[0],arr[1],arr[2], arr[3],arr[4]);	
		//trace(GetResFunc); 
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
		_root.getURL("javascript:ReceiveDataFromAS("+ _root[CurMovie][CurField] +");"); 
	else
		_root.getURL("javascript:ReceiveDataFromAS("+ _root[CurField] +");");
}
addProperty("GetData",GetStatus,SetGetData);



//CurMovie = MovieClip1;
//GotoAndStop = 1;
//CurMovie = "MovieClip1";
//CurField = "text";
//GetData = 1;
//SetVar = 0;
//CountParamFunc = 2;
//curField = "stop";
//curField = "Func";
//RunFunc = "1;;2";