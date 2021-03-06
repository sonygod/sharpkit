if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}

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

if (typeof($CreateAnonymousObject)=='undefined') 
{
    var $CreateAnonymousObject = function(json)
    {
        var obj = new System.Object.ctor();
        obj.d = json;
        for(var p in json){
            obj['get_'+p] = new Function('return this.d.'+p+';');
        }
        return obj;
    }
}


if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Dynamics) == "undefined")
    CoreTests.Dynamics = {};
CoreTests.Dynamics.Dynamics = function (){
    this.data = null;
    this.selectedIndex = 0;
    this.HOW_LONG = 0;
};
CoreTests.Dynamics.Dynamics.prototype.TestMethod = function (){
    var d;
};
CoreTests.Dynamics.Dynamics.prototype.parse = function (dateNode){
    var dateString = dateNode["$t"];
    dateNode("asdas");
    var x = dateNode.ggg.aaa;
    dateNode.aa.bb = "dd";
};
CoreTests.Dynamics.Dynamics.ContainsIgnoreCase = function (str, other){
    return (str.ToLower().IndexOf(other.ToLower())) > -1;
};
CoreTests.Dynamics.Dynamics.prototype.selectByURL = function (url){
    var dataRef = this.data;
    var item;
    for (var i = 0; i < dataRef.length; i++){
        item = dataRef[i];
        if (item.url == url){
            if (this.selectedIndex != i){
                this.selectedIndex = i;
            }
            break;
        }
    }
};
CoreTests.Dynamics.Dynamics.prototype.foo = function (){
    var arrivingViewProps = new Object();
    arrivingViewProps.left = 0;
    arrivingViewProps.leaveTransforms = true;
    this.animate(arrivingViewProps, this.HOW_LONG);
};
CoreTests.Dynamics.Dynamics.prototype.animate = function (arrivingViewProps, HOW_LONG){
    throw $CreateException(new System.NotImplementedException.ctor(), new Error());
};
CoreTests.Dynamics.Dynamics.prototype.foo2 = function (){
    var arrivingView = null;
    var arrivingViewProps = new Object();
    arrivingViewProps.left = 0;
    arrivingViewProps.leaveTransforms = true;
    var newLeftSide = 7;
    arrivingView.show();
    arrivingView.css("left", newLeftSide);
    arrivingView.animate(arrivingViewProps, this.HOW_LONG);
};
CoreTests.Dynamics.Dynamics.prototype.foo3 = function (){
    var reminders = null;
    var $it1 = reminders.GetEnumerator();
    while ($it1.MoveNext()){
        var item = $it1.get_Current();
    }
};
CoreTests.Dynamics.Dynamics.prototype.foo4 = function (){
    var parseResult = $CreateDelegate(this, this.foo5);
};
CoreTests.Dynamics.Dynamics.prototype.foo5 = function (obj){
    var reminders =  [];
    var reminder;
    var now = new Date();
    var startOfToday = new Date(now.getFullYear(), now.getMonth(), now.getDate(), 0, 0, 0, 0);
    var dueDate;
    for (var $i3 = 0,$l3 = reminders.length,item = reminders[$i3]; $i3 < $l3; $i3++, item = reminders[$i3]){
        dueDate = new Date(item.DueDate["$t"]);
        reminder = new Object();
        reminder["Due"] = item.DueDate["$t"];
        reminder["Done"] = item.PrevDate["$t"];
        reminder["Subject"] = item.Description["$t"];
        reminder["PastDue"] = dueDate.getTime() < startOfToday.getTime() ? "red" : "";
        this.data.push(reminder);
    }
};
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Dynamics$Bug1 = {
    fullname: "CoreTests.Dynamics.Bug1",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        },
        send: function (){
            this.send$$String("");
            this.send$$Object($CreateAnonymousObject({
                a: "b"
            }));
            var c = null;
            this.send$$Object(c);
        },
        send$$Object: function (json){
        },
        send$$String: function (json){
        }
    }
};
JsTypes.push(CoreTests$Dynamics$Bug1);
CoreTests.Dynamics.MichaelTest = function (){
    this.blah = null;
};
CoreTests.Dynamics.MichaelTest.prototype.foo = function (){
    var wtf = this.blah;
    var grid = wtf;
};
CoreTests.Dynamics.jQuery2 = function (){
};
CoreTests.Dynamics.MichaelTest2 = function (){
    this._type = null;
};
CoreTests.Dynamics.MichaelTest2.prototype.foo = function (){
    var x = this.get_type();
};
CoreTests.Dynamics.MichaelTest2.prototype.get_type = function (){
    return this._type;
};

