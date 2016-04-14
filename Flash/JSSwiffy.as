// insert command in ExampleFla.fla
// #include "JSSwiffy.as"
// ActionScript 2.0
var CurMovie:String = "";
var CurField:String = "";

GetStatus=function()
{
	return "";
}

SetGotoAndStop = function(value){
	eval(CurMovie).gotoAndStop(value);	
}
addProperty("GotoAndStop",GetStatus,SetGotoAndStop);


SetSetVar = function(value){	
	_root[CurMovie][CurField] = value;
}

addProperty("SetVar",GetStatus,SetSetVar);


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
//CurMovie = "Text1";
//CurField = "text";
//GetData = 1;
//SetVar = 0;

