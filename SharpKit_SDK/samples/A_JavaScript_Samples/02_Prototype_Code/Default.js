/*@Generated by SharpKit v4.22.1000*/
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
PrototypeCodeSample = function()
{
    this.InstanceProperty = "some default value";
}
PrototypeCodeSample.prototype.InstanceFunction = function(value)
{
    this.InstanceProperty = value;
}
PrototypeCodeSample.StaticFunction = function(value)
{
    PrototypeCodeSample.StaticProperty = value;
}
function btn_onclick()
{
    PrototypeCodeSample.StaticFunction("some static value");
    alert("PrototypeCodeSample.StaticProperty: \"" + PrototypeCodeSample.StaticProperty + "\"");
    var obj=new PrototypeCodeSample();
    obj.InstanceFunction("some instance value");
    alert("obj.InstanceProperty: \"" + obj.InstanceProperty + "\"");
}
