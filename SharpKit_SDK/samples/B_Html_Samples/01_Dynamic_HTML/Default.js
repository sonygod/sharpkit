/*@Generated by SharpKit v4.22.4000*/
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
function tbNewTask_onkeypress(textbox,e)
{
    if(e.keyCode == 13)
    {
        textbox.blur();
        return false;
    }
    return true;
}
function tbNewTask_onblur(textbox)
{
    if(textbox.value == null || textbox.value == "")
        return false;
    var li=document.createElement("li");
    li.appendChild(document.createTextNode(textbox.value));
    var liNewTask=document.getElementById("liNewTask");
    liNewTask.insertAdjacentElement("beforeBegin",li);
    textbox.value = "";
    textbox.focus();
    return true;
}
