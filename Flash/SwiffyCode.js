
	var stage = new swiffy.Stage(document.getElementById('swiffycontainer'),
          swiffyobject, {});   
    		  
    // Default. Set data from URL. Example Set Text1 = Text 1 and Text1 = 2 -  ?Text1=Text+1&Text2=2
	/*var myQueryString=document.location.search;
	if (myQueryString[0]='?')
	{
		myQueryString=myQueryString.substr(1, myQueryString.length-1);
		//SetVariable("'"+myQueryString+"&&'");
	}*/    
    
	stage.start();	  

    // Action for JS Button	
    var i = 0;	  
    var reply_click = function()
    {
	   i=i+1;
	   SetVariable("VarText1=6");
	   //SetVariable("StrMovie=MovieClip1&GotoAndStop=2");
	   SetGotoAndStop("MovieClip1","2");			
	   //SetVariable("StrMovie=Text1&StrField=text&SetVar=100");
	   SetField("Text1","text", i);
	   SetVariable("GetData=1"); 
    }
    document.getElementById("textChanger").onclick = reply_click;
	
	// Function

    var SetVariable = function(Variable ){
       stage.setFlashVars(Variable);	
    }

    var SetField = function(NameMovie,NameField, Variable ){
       stage.setFlashVars("CurMovie="+NameMovie+"&CurField="+NameField+"&SetVar="+Variable);	
    }

    var SetGotoAndStop = function(NameMovie,NumberFrame ){
      stage.setFlashVars("CurMovie="+NameMovie+"&GotoAndStop="+NumberFrame+"");	
    }

	var VarGetData = "";
	function ReceiveDataFromAS(args) {
	   VarGetData = args;
	   window.external.EventForGetData(VarGetData);
       //alert(args);
    }
	
	