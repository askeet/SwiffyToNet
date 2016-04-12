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

