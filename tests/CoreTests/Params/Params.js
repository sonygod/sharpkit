
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Params$Params = {
    fullname: "CoreTests.Params.Params",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition: {
        ctor: function (){
            System.Object.ctor.call(this);
        },
        foo: function (){
            var x = System.String.Format$$String$$Object$Array("{0}{1}{2}", ["a", "b", "c", "d"]);
            this.foo2(["a", "b", "c"]);
        },
        foo2: function (prms){
        }
    }
};
JsTypes.push(CoreTests$Params$Params);

