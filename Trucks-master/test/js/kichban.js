

$(document).ready(function(){

    var ds = document.getElementById("list").children;	
    
	setInterval(function(){myFunct(ds)},1000);
})

var i=0;
function myFunct(dss){
	
	$(dss[i]).css("display","none");
	i++;
	if(i >= dss.length)
		i=0;
	$(dss[i]).css("display","block");
	//showlog(dss);
}
function showlog(dss){
	if(dss.length >0)
		for(var j=0; j< dss.length;j++)
		{
			if($(j).attr("display") == "block")
				alert($(j).nodeName);
		}
}