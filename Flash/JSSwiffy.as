// insert command in ExampleFla.fla
// #include "JSSwiffy.as"

// ActionScript 2.0
var CurMovie:String = "0";
var CurField:String = "0";
var CountParams:Number = 0;
var GetResFunc:Object;
var KindRunFunc:String =""; // Set not "" and first agrument for RunFunc = eval(String(arr[0])).
var UserObject = new Object(); // Object for store Variables for RunFunc
var TypeVarIsNum:String = "";// Variable is Number if it isn't "" 


GetStatus=function()
{
	return "";
}

SetGotoAndStop = function(value){
	eval(String(CurMovie)).gotoAndStop(value);	
}
addProperty("GotoAndStop",GetStatus,SetGotoAndStop);

// Run any function 
// value is string like "1;;2;;3" where ";;" splits params
// Max count params for func is 6
SetRunFunc = function(value){
	if(curField!="0"){
		var arr:Array = new Array(6); 
		arr = value.split(";;"); 
		if(KindRunFunc==""){
			GetResFunc = 
			  eval((CurMovie!="0")? String(CurMovie)+"."+String(CurField) : String(CurField))
			  (String(arr[0]),String(arr[1]),String(arr[2]), String(arr[3]),String(arr[4]),String(arr[5]));
        }else{
			  eval((CurMovie!="0")? String(CurMovie)+"."+String(CurField) : String(CurField))
			 // (UserObject) /*, String(arr[1]),String(arr[2]), String(arr[3]),String(arr[4]),String(arr[5])*/);
			  (eval(String(arr[0])) /*, String(arr[1]),String(arr[2]), String(arr[3]),String(arr[4]),String(arr[5])*/);

			  KindRunFunc = "";
			  
			  //Text1.text = String((CurMovie!="0")? (String(CurMovie)+"."+String(CurField)) : String(CurField));
			  //Text2.text = String(arr[0])+" "+UserObject.x;
		}				
	}		
}
addProperty("RunFunc",GetStatus,SetRunFunc);


SetSetVar = function(value){	
     if(curField!="0"){
		 if(CurMovie!="0")
			eval(String(CurMovie))[String(CurField)] = (TypeVarIsNum=="")? value : Number(value);
		 else
			_root[String(CurField)] = (TypeVarIsNum=="")? value : Number(value);
         TypeVarIsNum ="";			
	 }
}
addProperty("SetVar",GetStatus,SetSetVar);

// Receive Value 
// if param = 1 result= CurMovie.CurField
// else result= CurField
SetGetData = function(value){
	//flash.external.ExternalInterface.call("jsFunction", "Hello");
	if( value== "1")
		_root.getURL("javascript:ReceiveDataFromAS('"+ eval(String(CurMovie))[String(CurField)] +"');"); 
	else
		_root.getURL("javascript:ReceiveDataFromAS('"+eval(String(CurField))+"');");
}
addProperty("GetData",GetStatus,SetGetData);

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
//var NewObject:Object = new Object(); // = {x:0, y:0};;
//NewObject ="1";
/*eval("UserObject")["x"] = 12; 

trace("1 =" + eval("UserObject.x"));
trace("2=" +_root["UserObject"].x);*/

//UserObject.x = 0; // 157.4
//UserObject.y = 0; // 105.22
/*UserObject.x = Number("11"); // 157.4
UserObject.y = Number("10"); // 105.22
CurMovie = "MovieClip1";
CurField = "localToGlobal";
KindRunFunc = "1";
RunFunc = "UserObject";
//eval("MovieClip1.localToGlobal")(eval("UserObject"));
//MovieClip1.localToGlobal(UserObject);
trace(UserObject.y);*/




