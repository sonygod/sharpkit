if (typeof(SharpKitWebApp5) == "undefined")
    var SharpKitWebApp5 = {};
SharpKitWebApp5.Foo2 = function ()
{
};
SharpKitWebApp5.Foo2.prototype.test = function ()
{
    var b;
    (function ()
    {
        b = {Value: b};
        var $res = this.foo1(1, b);
        b = b.Value;
        return $res;
    }).call(this);
};
SharpKitWebApp5.Foo2.prototype.foo1 = function (a, outB)
{
    this.foo2(1, outB);
    outB.Value = 7;
};
SharpKitWebApp5.Foo2.prototype.foo2 = function (a, outC)
{
    outC.Value = 2;
};