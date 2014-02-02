if (typeof ($Inherit) == 'undefined') {
	var $Inherit = function (ce, ce2) {

		if (typeof (Object.getOwnPropertyNames) == 'undefined') {

			for (var p in ce2.prototype)
				if (typeof (ce.prototype[p]) == 'undefined' || ce.prototype[p] == Object.prototype[p])
					ce.prototype[p] = ce2.prototype[p];
			for (var p in ce2)
				if (typeof (ce[p]) == 'undefined')
					ce[p] = ce2[p];
			ce.$baseCtor = ce2;

		} else {

			var props = Object.getOwnPropertyNames(ce2.prototype);
			for (var i = 0; i < props.length; i++)
				if (typeof (Object.getOwnPropertyDescriptor(ce.prototype, props[i])) == 'undefined')
					Object.defineProperty(ce.prototype, props[i], Object.getOwnPropertyDescriptor(ce2.prototype, props[i]));

			for (var p in ce2)
				if (typeof (ce[p]) == 'undefined')
					ce[p] = ce2[p];
			ce.$baseCtor = ce2;

		}

	}
};


if (typeof(SharpKitWebApp5) == "undefined")
    var SharpKitWebApp5 = {};
SharpKitWebApp5.Class8_Base = function (){
    this.prop = 10;
};
SharpKitWebApp5.Class8_Base.prototype.get_MyProperty = function (){
    return this.prop;
};
SharpKitWebApp5.Class8_Base.prototype.set_MyProperty = function (value){
    this.prop = value;
};
Object.defineProperty(SharpKitWebApp5.Class8_Base.prototype, "MyProperty", {
    get: SharpKitWebApp5.Class8_Base.prototype.get_MyProperty,
    set: SharpKitWebApp5.Class8_Base.prototype.set_MyProperty
});
SharpKitWebApp5.Class8_Inherit = function (){
    this.prop = 10;
    SharpKitWebApp5.Class8_Base.call(this);
};
SharpKitWebApp5.Class8_Inherit.prototype.get_MyProperty = function (){
    return SharpKitWebApp5.Class8_Base.prototype.get_MyProperty.call(this);
};
SharpKitWebApp5.Class8_Inherit.prototype.set_MyProperty = function (value){
    SharpKitWebApp5.Class8_Base.prototype.set_MyProperty.call(this, value);
};
Object.defineProperty(SharpKitWebApp5.Class8_Inherit.prototype, "MyProperty", {
    get: SharpKitWebApp5.Class8_Inherit.prototype.get_MyProperty,
    set: SharpKitWebApp5.Class8_Inherit.prototype.set_MyProperty
});
$Inherit(SharpKitWebApp5.Class8_Inherit, SharpKitWebApp5.Class8_Base);
SharpKitWebApp5.Class8_GetSetProp = function (){
};
SharpKitWebApp5.Class8_GetSetProp.prototype.Main = function (){
    var bar = null;
    var foo = bar.get_MyProperty();
    bar.set_MyProperty(bar.get_MyProperty());
};

