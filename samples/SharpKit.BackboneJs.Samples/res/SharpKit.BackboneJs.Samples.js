/*Generated by SharpKit 5 v4.29.2000*/
if (typeof($CreateDelegate)=='undefined'){
    if(typeof($iKey)=='undefined') var $iKey = 0;
    if(typeof($pKey)=='undefined') var $pKey = String.fromCharCode(1);
    var $CreateDelegate = function(target, func){
        if (target == null || func == null) 
            return func;
        if(func.target==target && func.func==func)
            return func;
        if (target.$delegateCache == null)
            target.$delegateCache = {};
        if (func.$key == null)
            func.$key = $pKey + String(++$iKey);
        var delegate;
        if(target.$delegateCache!=null)
            delegate = target.$delegateCache[func.$key];
        if (delegate == null){
            delegate = function(){
                return func.apply(target, arguments);
            };
            delegate.func = func;
            delegate.target = target;
            delegate.isDelegate = true;
            if(target.$delegateCache!=null)
                target.$delegateCache[func.$key] = delegate;
        }
        return delegate;
    }
}
if(typeof(JsTypes) == "undefined")
    var JsTypes=[];
var SharpKit$BackboneJs$Todo=
{
    fullname:"SharpKit.BackboneJs.Todo",
    baseTypeName:"Backbone.Model",
    assemblyName:"SharpKit.BackboneJs.Samples",
    Kind:"Class",
    definition:
    {
        defaults:function()
        {
            return {title:"empty"};
        },
        initialize:function()
        {
            if(!this.get("title"))
            {
                this.set({title:this.defaults.title});
            }
        },
        toggle:function()
        {
            this.save({done:!this.get("done")});
        }
    }
};
JsTypes.push(SharpKit$BackboneJs$Todo);
window.Todo = Backbone.Model.extend(JsTypes[JsTypes.length-1].definition);
var SharpKit$BackboneJs$TodoCollection={fullname:"SharpKit.BackboneJs.TodoCollection",baseTypeName:"Backbone.Collection",assemblyName:"SharpKit.BackboneJs.Samples",Kind:"Class"};
JsTypes.push(SharpKit$BackboneJs$TodoCollection);
window.TodoList = Backbone.Collection.extend(JsTypes[JsTypes.length-1].definition);
var SharpKit$BackboneJs$TodoView=
{
    fullname:"SharpKit.BackboneJs.TodoView",
    baseTypeName:"Backbone.View",
    assemblyName:"SharpKit.BackboneJs.Samples",
    Kind:"Class",
    definition:
    {
        initialize:function()
        {
            this.model.bind("change",$CreateDelegate(this,this.render),this);
            this.model.bind("destroy",$CreateDelegate(this,this.remove),this);
        }
    }
};
JsTypes.push(SharpKit$BackboneJs$TodoView);
window.TodoView = Backbone.View.extend(JsTypes[JsTypes.length-1].definition);
