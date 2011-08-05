
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null)return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null){$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){d=function(){return arguments.callee.func.apply(arguments.callee.target,arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
JsCompiler=function()
{}
JsCompiler.Compile_Direct=function()
{JsCompiler.Compile_Phase1();JsCompiler.Compile_Phase2();JsCompiler.Compile_Phase3();}
JsCompiler.Compile_Phase1=function()
{for(var i=0;i<BeforeCompilationFunctions.length;i++)
{BeforeCompilationFunctions[i].call(BeforeCompilationCallers[i]);}
BeforeCompilationFunctions=new Array();BeforeCompilationCallers=new Array();for(var i=0;i<JsTypes.length;i++)
{var jsType=JsTypes[i];var fullName=jsType.fullname;var type=JsCompiler.Types[fullName];if(type==null)
{JsCompiler.Types[fullName]=jsType;}
else
{jsType.isPartial=true;jsType.realType=type;}
if(jsType.derivedTypes==null)
jsType.derivedTypes=new Array();if(jsType.interfaces==null)
jsType.interfaces=new Array();if(jsType.definition==null)
jsType.definition=new Object();var index=fullName.lastIndexOf(".");if(index==-1)
{jsType.name=fullName;}
else
{jsType.name=fullName.substring(index+1);jsType.ns=fullName.substring(0,index);}
if(jsType.isEnum)
{if(jsType.baseTypeName==null)
jsType.baseTypeName="System.Object";if(jsType.definition["ToString"]==null)
jsType.definition["ToString"]=new Function("return this._Name;");}
else if(jsType.isValueType)
{if(type.baseTypeName==null)
type.baseTypeName="System.ValueType";}}}
JsCompiler.Compile_Phase2=function()
{for(var i=0;i<JsTypes.length;i++)
{var jsType=JsTypes[i];JsCompiler.Compile_Phase2_TmpType(jsType);}
JsTypes=new Array();}
JsCompiler.Compile_Phase2_TmpType=function(tmpType)
{var p=tmpType.fullname;var type=null;type=JsCompiler.CompileType(tmpType);if(type!=null)
JsCompiler.CopyMemberIfNotDefined(type,type.fullname,window);if(type.ns!=null)
{var ns=JsCompiler.ResolveNamespace(type.ns);if(type!=null)
ns[type.name]=type;}}
JsCompiler.Compile_Phase3=function()
{var funcs=AfterCompilationFunctions;var callers=AfterCompilationCallers;AfterCompilationFunctions=new Array();AfterCompilationCallers=new Array();for(var i=0;i<funcs.length;i++)
{funcs[i].call(callers[i]);}
IsCompiled=true;}
JsCompiler.CopyMemberIfNotDefined=function(source,name,target)
{if(target[name]===undefined)target[name]=source;}
JsCompiler._CopyObject=function(source,target)
{for(var p in source)
target[p]=source[p];if(source.toString!=Object.prototype.toString&&target.toString==Object.prototype.toString)
target.toString=source.toString;}
JsCompiler._SafeCopyObject=function(source,target)
{for(var p in source)
{if(typeof(target[p])!='undefined')
{}
else
target[p]=source[p];}
if(source.toString!=Object.prototype.toString)
{}}
JsCompiler._EnumTryParse=function(name)
{return this.staticDefintion[name];}
JsCompiler.NewByFunc=function(ctor)
{return new ctor();}
JsCompiler.NewByFuncArgs=function(ctor,args)
{return new ctor.apply(null,args);}
JsCompiler.GetNativeToStringFunction=function()
{return Object.prototype.toString;}
JsCompiler.Throw=function(exception)
{__LastException=exception||__LastException;var error=new Error(exception.ToString());error['_Exception']=exception;throw error;}
JsCompiler.CreateEmptyCtor=function()
{return function(){};}
JsCompiler.CreateBaseCtor=function()
{return function(){this.construct();};}
if(typeof(Node)=='undefined')
Node=function(){};JsCompiler.Types=new Object();JsCompiler.ResolveNamespace=function(nsText)
{var ns=window;var tokens=nsText.split('.');for(var i=0;i<tokens.length;i++)
{var token=tokens[i];if(typeof(ns[token])=="undefined")
ns[token]={};ns[token].name=tokens.slice(0,i).join(".");ns=ns[token];}
return ns;}
JsCompiler.ResolveBaseType=function(type,currentType)
{var baseType=JsTypeHelper.GetType(type.baseTypeName);if(baseType==null)
baseType=JsTypeHelper.GetTypeIgnoreNamespace(type.baseTypeName,true);if(!baseType.isCompiled)
JsCompiler.CompileType(baseType);currentType.baseType=baseType;baseType.derivedTypes.push(currentType);}
JsCompiler.ResolveInterfaces=function(type,currentType)
{if(type.interfaceNames==null)
return;for(var i=0;i<type.interfaceNames.length;i++)
{var iName=type.interfaceNames[i];var iface=JsTypeHelper.GetType(iName);if(iface==null)
iface=JsTypeHelper.GetTypeIgnoreNamespace(iName,true);if(!iface.isCompiled)
JsCompiler.CompileType(iface);currentType.interfaces.push(iface);}}
JsCompiler.CompileType=function(type)
{var currentType=(JsCompiler.Types[type.fullname]!=null?JsCompiler.Types[type.fullname]:type);if(currentType.ctors==null)
currentType.ctors=new Object();if(!type.isCompiled)
{var baseTypeResolved=false;if(currentType.baseType==null&&currentType.baseTypeName!=null)
{JsCompiler.ResolveBaseType(type,currentType);if(currentType.baseType!=null)
baseTypeResolved=true;}
JsCompiler.ResolveInterfaces(type,currentType);for(var p in type.definition)
{if(p.search("ctor")==0)
{currentType[p]=type.definition[p];delete(type.definition[p]);if(typeof(currentType.commonPrototype)=="undefined")
currentType.commonPrototype=currentType[p].prototype;else
currentType[p].prototype=currentType.commonPrototype;currentType.ctors[p]=currentType[p];}}
if(currentType.ctor==null)
{if(currentType.ns==null||currentType.ns=="")
{var jsCtor=window[currentType.name];currentType.ctor=jsCtor;}
if(currentType.ctor==null&&currentType.ctors!=null)
{var createCtor=true;for(var p in currentType.ctors)
{createCtor=false;break;}
if(createCtor)
{if(currentType.baseType!=null)
currentType.ctor=JsCompiler.CreateBaseCtor();else
currentType.ctor=JsCompiler.CreateEmptyCtor();}}
if(currentType.ctor!=null)
{currentType.ctors["ctor"]=currentType.ctor;if(typeof(currentType.commonPrototype)=="undefined")
currentType.commonPrototype=currentType.ctor.prototype;else
currentType.ctor.prototype=currentType.commonPrototype;}}
for(var p in currentType.ctors)
{var ctor=currentType.ctors[p];if(ctor._type==null)
ctor._type=currentType;}
if(baseTypeResolved)
{JsCompiler._CopyObject(currentType.baseType.commonPrototype,currentType.commonPrototype);}
for(var p in type.definition)
{var member=type.definition[p];currentType.commonPrototype[p]=member;if(typeof(member)=="function")
{member._name=p;member._type=currentType;}}
if(type.definition.toString!=Object.prototype.toString)
{currentType.commonPrototype.toString=type.definition.toString;currentType.commonPrototype.toString.name="toString";currentType.commonPrototype.toString._type=currentType;}
for(var p in type.staticDefinition)
{var member=type.staticDefinition[p];currentType[p]=member;if(typeof(member)=="function")
{member._name=p;member._type=currentType;}}
type.isCompiled=true;}
JsCompiler.CompileEnum(currentType);if(currentType!=type&&type.customAttributes!=null)
{if(currentType.customAttributes!=null)
{for(var i=0;i<type.customAttributes.length;i++)
{currentType.customAttributes.push(type.customAttributes[i]);}}
else
{currentType.customAttributes=type.customAttributes;}}
return currentType;}
JsCompiler.CompileEnum=function(currentType)
{if(currentType.isEnum)
{currentType.tryParse=JsCompiler._EnumTryParse;for(var p in currentType.staticDefinition)
{if(typeof(currentType.staticDefinition[p])=="string")
{var x=JsCompiler.NewByFunc(currentType.ctor);x["_Name"]=p;currentType.staticDefinition[p]=x;currentType[p]=x;}}}}
JsCompiler._hashKeyIndex=0;JsCompiler._hashKeyPrefix=String.fromCharCode(1);JsCompiler.GetHashKey=function(obj)
{if(obj==undefined)
return"undefined";if(obj==null)
return"null";if(obj.valueOf)
obj=obj.valueOf();var type=typeof(obj);if(type=="string")
return obj;if(type=="object"||type=="function")
{if(obj._hashKey==null)
{obj._hashKey=JsCompiler._hashKeyPrefix+JsCompiler._hashKeyIndex;JsCompiler._hashKeyIndex++;}
return obj._hashKey;}
return obj.toString();}
AfterCompilation($CreateDelegate(this,function(){JsTypeHelper.GetTypeIgnoreNamespace_Cache=new Object();}),null);function RemoveDelegate(delOriginal,delToRemove)
{if(delToRemove==null)
return delOriginal;if(delOriginal.isMulticastDelegate)
{if(delToRemove.isMulticastDelegate)
throw new System.NotImplementedException.ctor$$String("Multicast to multicast delegate removal is not implemented yet");var del=CreateMulticastDelegateFunction();for(var i=0;i<delOriginal.delegates.length;i++)
{var del2=delOriginal.delegates[i];if(del2==delToRemove)
{del.delegates=delOriginal.delegates.splice(i,1);break;}}
if(del.delegates==null)
del.delegates=delOriginal.delegates.splice(0,0);if(del.delegates.length==1)
return del.delegates[0];return del;}
else
{if(delToRemove.isMulticastDelegate)
throw new System.NotImplementedException.ctor$$String("single to multicast delegate removal is not supported");if(delOriginal==delToRemove)
return null;return delOriginal;}}
function CombineDelegates(del1,del2)
{if(del1==null)
return del2;if(del2==null)
return del1;var del=CreateMulticastDelegateFunction();del.delegates=new Array();if(del1.isMulticastDelegate)
{for(var i=0;i<del1.delegates.length;i++)
del.delegates.push(del1.delegates[i]);}
else
{del.delegates.push(del1);}
if(del2.isMulticastDelegate)
{for(var i=0;i<del2.delegates.length;i++)
del.delegates.push(del2.delegates[i]);}
else
{del.delegates.push(del2);}
return del;}
function CreateMulticastDelegateFunction()
{var del=function(){var del2=arguments.callee;var x=undefined;for(var i=0;i<del2.delegates.length;i++)
{var del3=del2.delegates[i];x=del3.apply(null,arguments);}
return x;};del.isMulticastDelegate=true;return del;}
function CreateClrDelegate(type,genericArgs,target,func)
{return JsTypeHelper.GetDelegate(target,func);}
function Typeof(jsTypeOrName)
{if(jsTypeOrName==null)
throw new Error("Unknown type.");if(typeof(jsTypeOrName)=="string")
return System.Type.GetType$$String$$Boolean(jsTypeOrName,true);return System.Type._TypeOf(jsTypeOrName);}
function JsTypeof(typeName)
{return JsTypeHelper.GetType(typeName,false);}
function New(typeName,args)
{var type=JsTypeHelper.GetType(typeName,true);if(args==null||args.length==0)
{var obj=JsCompiler.NewByFunc(type.ctor);return obj;}
else
{var obj=JsCompiler.NewByFuncArgs(type.ctor,args);return obj;}}
function NewWithInitializer(type,json)
{var obj=JsCompiler.NewByFunc(type.ctor);if(typeof(json)=="array")
{throw new System.Exception.ctor$$String("not implemented");}
else
{for(var p in json)
{var setter=obj["set_"+p];if(typeof(setter)=="function")
setter.call(obj,json[p]);else
obj[p]=json[p];}}
return obj;}
function NewAtServer(type,args)
{throw new System.NotImplementedException.ctor();}
function As(obj,typeOrName)
{if(obj==null)
return obj;var type=JsTypeHelper.GetType(typeOrName,true);if(Is(obj,type))
return obj;return null;}
function Cast(obj,typeOrName)
{if(obj==null)
return obj;var type=JsTypeHelper.GetType(typeOrName,true);if(Is(obj,type))
return obj;var converted=TryImplicitConvert(obj,type);if(converted!=null)
return converted;var objTypeName=typeof(obj);if(typeof(obj.getTypeName)=="function")
{objTypeName=obj.getTypeName();}
var msg=new Array("InvalidCastException: Cannot cast ",objTypeName," to ",type.fullname,"Exception generated by JsRuntime").join("");throw new Error(msg);}
function _TestTypeInterfacesIs(testType,iface,testedInterfaces)
{if(testedInterfaces[iface.name])
return false;for(var i=0;i<testType.interfaces.length;i++)
{var testIface=testType.interfaces[i];if(testIface==iface)
return true;testedInterfaces[testIface.name]=true;if(_TestTypeInterfacesIs(testIface,iface,testedInterfaces))
return true;}
return false;}
function TypeIs(objType,type)
{if(type.isInterface)
{var testedInterfaces=new Object();while(objType!=null)
{if(objType==type)
return true;if(_TestTypeInterfacesIs(objType,type,testedInterfaces))
return true;objType=objType.baseType;}}
else
{while(objType!=null)
{if(objType==type)
return true;objType=objType.baseType;}}
return false;}
function Is(obj,typeOrName)
{if(obj==null)
{return false;}
var type=JsTypeHelper.GetType(typeOrName,true);if(type==null)
throw new Error("type expected");var objType=GetObjectType(obj);var isIt=TypeIs(objType,type);return isIt;}
function Default(T)
{return null;}
function GetObjectType(obj)
{var objType;if(obj.constructor==null||obj instanceof Node||obj.constructor==HTMLImageElement||obj.constructor==HTMLInputElement||obj.constructor.name=='HTMLImageElement'||obj.constructor.name=='HTMLInputElement')
{var jsType=typeof(obj);var objTypeName=SharpKit.Html4.HtmlDom.GetTypeNameFromHtmlNode(obj);if(objTypeName==null)
throw new Error();objType=JsTypeHelper.GetType(objTypeName,true);}
else
{objType=obj.constructor._type;}
return objType;}
function TryImplicitConvert(obj,type)
{if(obj instanceof Error)
{if(obj._Exception!=null)
{if(Is(obj._Exception,type))
return obj._Exception;else
return null;}
else if(type.get_FullName()=='System.Exception')
{obj._Exception=new Exception(obj.message);return obj._Exception;}}
return null;}
function Compile()
{JsCompiler.Compile_Direct();}
var AfterCompilationFunctions=new Array();var AfterCompilationCallers=new Array();function AfterCompilation(func,caller)
{if(IsCompiled)
func.call(caller);else
{AfterCompilationFunctions.push(func);AfterCompilationCallers.push((caller!=null?caller:null));}}
function AfterNextCompilation(func,caller)
{AfterCompilationFunctions.push(func);AfterCompilationCallers.push((caller!=null?caller:null));}
var BeforeCompilationFunctions=new Array();var BeforeCompilationCallers=new Array();function BeforeCompilation(func,caller)
{BeforeCompilationFunctions.push(func);BeforeCompilationCallers.push((caller!=null?caller:null));}
var IsCompiled=false;JsTypeHelper=function()
{}
JsTypeHelper.GetTypeIgnoreNamespace=function(name,throwIfNotFound)
{var type;var cache=JsTypeHelper.GetTypeIgnoreNamespaceCache;if(cache!=null)
{type=cache[name];if(typeof(type)!="undefined")
{if(throwIfNotFound&&type==null)
throw new Error("type "+name+" was not found with (with IgnoreNamespace).");return type;}}
if(name.search(".")>-1)
{var tokens=name.split(".");name=tokens[tokens.length-1];}
type=JsCompiler.Types[name];var nameAfterNs="."+name;if(type==null)
{for(var p in JsCompiler.Types)
{if(p==name||p.endsWith(nameAfterNs))
{type=JsCompiler.Types[p];break;}}}
if(throwIfNotFound&&type==null)
throw new Error("type "+name+" was not found with (with IgnoreNamespace).");if(cache!=null)
cache[name]=(type!=null?type:null);return type;}
JsTypeHelper.GetTypeIgnoreNamespaceCache=null;JsTypeHelper._HasTypeArguments=function(typeName)
{return typeName.indexOf("[")>-1;}
JsTypeHelper._GetTypeWithArguments=function(typeName,throwIfNotFound)
{var name=typeName;var gti=name.indexOf("`");if(gti!=-1&&name.indexOf("[")>-1)
{var args=JsTypeHelper._ParseTypeNameArgs(name);var type=JsTypeHelper.GetType(args[0],throwIfNotFound);if(type==null)
return null;var res=[];res.push(type);var typeArgs=[];for(var i=0;i<args[1].length;i++)
{var typeArg=JsTypeHelper.GetType(args[1][i][0],throwIfNotFound);if(typeArg==null)
return null;typeArgs.push(typeArg);}
res.push(typeArgs);return res;}
return null;}
JsTypeHelper._ParseTypeNameArgs=function(name)
{var code=name.replace(/, [a-zA-Z0-9, =.]+\]/g,']');code=code.replace(/`([0-9])/g,'$$$1,');code='['+code+']';var args=eval(code);return args;}
JsTypeHelper.GetType=function(typeOrName,throwIfNotFound)
{if(typeof(typeOrName)!="string")
{if(typeof(typeOrName)=="function")
return typeOrName._type;return typeOrName;}
var name=typeOrName;var gti=name.indexOf("`");if(gti!=-1)
{name=name.substr(0,gti+2).replace("`","$");}
var type=JsCompiler.Types[name];if(type==null)
{if(throwIfNotFound)
throw new Error("JsType "+name+" was not found");return null;}
return type;}
JsTypeHelper.FindType=function(name,throwIfNotFound)
{var type=JsTypeHelper.GetType(name,false);if(type==null)
type=JsTypeHelper.GetTypeIgnoreNamespace(name,throwIfNotFound);return type;}
JsTypeHelper.GetAssemblyQualifiedName=function(type)
{if(type._AssemblyQualifiedName==null)
{var name=type.fullname;if(type.assemblyName!=null)
name+=", "+type.assemblyName;type._AssemblyQualifiedName=name;}
return type._AssemblyQualifiedName;}
JsTypeHelper.GetName=function(type)
{return type.name;}
JsTypeHelper.getMemberTypeName=function(instance,memberName)
{var signature=instance[memberName+"$$"];if(signature==null)
return null;var tokens=signature.split(" ");var memberTypeName=tokens[tokens.length-1];return memberTypeName;}
JsTypeHelper.GetDelegate=function(obj,func)
{var target=obj;if(target==null)
return func;if(typeof(func)=="string")
func=target[func];var cache=target.__delegateCache;if(cache==null)
{cache=new Object();target.__delegateCache=cache;}
var key=JsCompiler.GetHashKey(func);var del=cache[key];if(del==null)
{del=function(){var del2=arguments.callee;return del2.func.apply(del.target,arguments);};del.func=func;del.target=target;del.isDelegate=true;cache[key]=del;}
return del;}