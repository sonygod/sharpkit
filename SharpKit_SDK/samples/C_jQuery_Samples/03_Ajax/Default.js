if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}

/*@AutoGenerated*/
function btn_onclick()
{
    var prmValue=$("#textbox1").val();
    $.getJSON("MyHandler.ashx",{
        prm:prmValue}
    ,function(data,status,req)
    {
        alert("Server returned: " + data.NewValue);
    }
    
    );
}

