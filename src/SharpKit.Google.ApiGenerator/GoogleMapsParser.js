/* Generated by SharpKit 5 v5.4.4 */
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

if (typeof ($CreateAnonymousDelegate) == 'undefined') {
    var $CreateAnonymousDelegate = function (target, func) {
        if (target == null || func == null)
            return func;
        var delegate = function () {
            return func.apply(target, arguments);
        };
        delegate.func = func;
        delegate.target = target;
        delegate.isDelegate = true;
        return delegate;
    }
}


if (typeof(SharpKit) == "undefined")
    var SharpKit = {};
if (typeof(SharpKit.Google) == "undefined")
    SharpKit.Google = {};
if (typeof(SharpKit.Google.ApiGenerator) == "undefined")
    SharpKit.Google.ApiGenerator = {};
SharpKit.Google.ApiGenerator.GoogleMapsParser = function (){
    this.Writer = null;
    this.Assembly = null;
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.prototype.OnLoad = function (){
    this.Assembly = new SharpKit.Google.ApiGenerator.Assembly();
    this.Writer = new SharpKit.Google.ApiGenerator.CodeWriter();
    var body = $(document.body);
    for (var $i2 = 0,$t2 = body.children("h2"),$l2 = $t2.length,ch = $t2[$i2]; $i2 < $l2; $i2++, ch = $t2[$i2]){
        var ce = SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseClass(ch);
        this.Assembly.Classes.push(ce);
    }
    this.FixAssembly();
    this.Writer.WriteLine("using System;\r\nusing SharpKit.JavaScript;\r\nusing SharpKit.Html;\r\n\r\nnamespace SharpKit.Google.Maps\r\n{");
    this.GenerateCode();
    var code = this.Writer.toString();
    var pre = $("#Output");
    pre.val(code).remove();
    body[0].insertBefore(pre[0], body[0].firstChild);
    this.Writer.WriteLine("}");
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.prototype.FixAssembly = function (){
    for (var $i3 = 0,$t3 = this.Assembly.Classes,$l3 = $t3.length,ce = $t3[$i3]; $i3 < $l3; $i3++, ce = $t3[$i3]){
        for (var $i4 = 0,$t4 = ce.Members,$l4 = $t4.length,me = $t4[$i4]; $i4 < $l4; $i4++, me = $t4[$i4]){
            SharpKit.Google.ApiGenerator.GoogleMapsParser.FixType(me.Type);
            if (me instanceof SharpKit.Google.ApiGenerator.Method){
                var me2 = me instanceof SharpKit.Google.ApiGenerator.Method || me == null ? me : (function (){
                    throw new Error("InvalidCastException");
                }
                ());
                for (var $i5 = 0,$t5 = me2.Parameters,$l5 = $t5.length,prm = $t5[$i5]; $i5 < $l5; $i5++, prm = $t5[$i5]){
                    SharpKit.Google.ApiGenerator.GoogleMapsParser.FixType(prm.Type);
                }
            }
        }
    }
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.FixType = function (ce){
    if (SharpKit.Google.ApiGenerator.Extensions.Contains(ce.Name, "|"))
        ce.Name = "object";
    ce.Name = ce.Name.replace("*", "object").replace("number", "JsNumber").replace("boolean", "bool").replace("number", "JsNumber").replace("Array.", "JsArray").replace("Object.", "JsObject").replace("MVCArray.", "MVCArray").replace("MVCJsArray.", "MVCArray");
    if (ce.Name == "None")
        ce.Name = "void";
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.prototype.GetDefaultValueCode = function (ce){
    if (ce == null || ce.Name == "void")
        return "";
    if (ce.Name == "bool")
        return "false";
    return "null";
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.prototype.GenerateCode = function (){
    for (var $i6 = 0,$t6 = this.Assembly.Classes,$l6 = $t6.length,ce = $t6[$i6]; $i6 < $l6; $i6++, ce = $t6[$i6]){
        this.WriteAttributes(ce);
        this.Writer.WriteLine("class " + ce.Name);
        this.Writer.BeginBlock();
        for (var $i7 = 0,$t7 = ce.Members,$l7 = $t7.length,me = $t7[$i7]; $i7 < $l7; $i7++, me = $t7[$i7]){
            if (me instanceof SharpKit.Google.ApiGenerator.Method){
                var me2 = me;
                this.WriteDescription(me);
                this.Writer.Write("public " + me.Type.Name + " " + me.Name + "(");
                this.Writer.Write(SharpKit.Google.ApiGenerator.Extensions.JsSelect(me2.Parameters, $CreateAnonymousDelegate(this, function (t){
                    return t.Type.Name + " " + t.Name + (t.IsOptional ? ("=" + this.GetDefaultValueCode(t.Type)) : "");
                })).join(", "));
                this.Writer.Write(")");
                if (me2.IsConstructor || me2.Type == null || me2.Type.Name == "void")
                    this.Writer.WriteLine("{}");
                else
                    this.Writer.WriteLine("{return " + this.GetDefaultValueCode(me2.Type) + ";}");
            }
            else if (me instanceof SharpKit.Google.ApiGenerator.Property){
                var pe = me;
                this.WriteDescription(pe);
                this.Writer.WriteLine("public " + (pe.IsStatic ? "static " : "") + me.Type.Name + " " + me.Name + "{get; set;}");
            }
        }
        this.Writer.EndBlock();
    }
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.prototype.WriteAttributes = function (ce){
    for (var $i8 = 0,$t8 = ce.Attributes,$l8 = $t8.length,att = $t8[$i8]; $i8 < $l8; $i8++, att = $t8[$i8])
        this.Writer.WriteLine(att.Code);
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.prototype.WriteDescription = function (me){
    if (me.Description == null || me.Description.length == 0)
        return;
    this.Writer.WriteLine("/// <summary>");
    for (var $i9 = 0,$t9 = me.Description.split("\n"),$l9 = $t9.length,line = $t9[$i9]; $i9 < $l9; $i9++, line = $t9[$i9]){
        this.Writer.WriteLine("///" + line);
    }
    this.Writer.WriteLine("/// </summary>");
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseClass = function (ch){
    var fullName = $(ch).text();
    var isClass = SharpKit.Google.ApiGenerator.Extensions.Contains(fullName, "class");
    var isJson = SharpKit.Google.ApiGenerator.Extensions.Contains(fullName, "object specification");
    fullName = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace(SharpKit.Google.ApiGenerator.Extensions.RemoveLast(SharpKit.Google.ApiGenerator.Extensions.RemoveLast(fullName, "class"), "object specification"));
    var tokens = fullName.split(".");
    var name = tokens[tokens.length - 1];
    tokens.splice(tokens.length - 1, 1);
    var ce = (function (){
        var $v1 = new SharpKit.Google.ApiGenerator.Class();
        $v1.Name = name;
        $v1.Members =  [];
        $v1.Namespace = tokens.join(".");
        return $v1;
    })();
    if (isJson)
        ce.Attributes.push((function (){
            var $v2 = new SharpKit.Google.ApiGenerator.Attribute();
            $v2.Code = "[JsType(JsMode.Json)]";
            return $v2;
        })());
    else
        ce.Attributes.push((function (){
            var $v3 = new SharpKit.Google.ApiGenerator.Attribute();
            $v3.Code = "[JsType(JsMode.Prototype, Name=\"" + ce.Namespace + "." + ce.Name + "\")]";
            return $v3;
        })());
    var tables = $(ch).nextUntil("h2").filter("table");
    for (var $i10 = 0,$l10 = tables.length,tbl = tables[$i10]; $i10 < $l10; $i10++, tbl = tables[$i10]){
        if (SharpKit.Google.ApiGenerator.Extensions.Contains(tbl.summary, "Constructor")){
            for (var $i11 = 0,$t11 = SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseMethods(tbl, true),$l11 = $t11.length,me = $t11[$i11]; $i11 < $l11; $i11++, me = $t11[$i11])
                ce.Members.push(me);
        }
        else if (SharpKit.Google.ApiGenerator.Extensions.Contains(tbl.summary, "Method")){
            for (var $i12 = 0,$t12 = SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseMethods(tbl, false),$l12 = $t12.length,me = $t12[$i12]; $i12 < $l12; $i12++, me = $t12[$i12])
                ce.Members.push(me);
        }
        else if (SharpKit.Google.ApiGenerator.Extensions.Contains(tbl.summary, "Prop")){
            for (var $i13 = 0,$t13 = SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseProperties(tbl),$l13 = $t13.length,me = $t13[$i13]; $i13 < $l13; $i13++, me = $t13[$i13])
                ce.Members.push(me);
        }
        else if (SharpKit.Google.ApiGenerator.Extensions.Contains(tbl.summary, "Constant")){
            for (var $i14 = 0,$t14 = SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseConstants(tbl),$l14 = $t14.length,me = $t14[$i14]; $i14 < $l14; $i14++, me = $t14[$i14])
                ce.Members.push(me);
        }
        else if (SharpKit.Google.ApiGenerator.Extensions.Contains(tbl.summary, "Event")){
            for (var $i15 = 0,$t15 = SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseEvents(tbl),$l15 = $t15.length,me = $t15[$i15]; $i15 < $l15; $i15++, me = $t15[$i15])
                ce.Members.push(me);
        }
    }
    return ce;
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseConstants = function (tbl){
    var list =  [];
    var trs = $(tbl).find("tbody > tr");
    for (var $i16 = 0,$l16 = trs.length,tr = trs[$i16]; $i16 < $l16; $i16++, tr = trs[$i16]){
        var cells = $(tr).children("td");
        var name = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace($(cells[0]).text());
        var type = "object";
        var desc = $(cells[1]).text();
        var me = (function (){
            var $v4 = new SharpKit.Google.ApiGenerator.Property();
            $v4.Name = name;
            $v4.Type = (function (){
                var $v5 = new SharpKit.Google.ApiGenerator.Class();
                $v5.Name = type;
                return $v5;
            })();
            $v4.Description = desc;
            $v4.IsStatic = true;
            return $v4;
        })();
        list.push(me);
    }
    return list;
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseProperties = function (tbl){
    var list =  [];
    var trs = $(tbl).find("> tbody > tr");
    for (var $i17 = 0,$l17 = trs.length,tr = trs[$i17]; $i17 < $l17; $i17++, tr = trs[$i17]){
        var cells = $(tr).children("td");
        var sig = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace($(cells[0]).text());
        var type = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace($(cells[1]).text());
        var desc = $(cells[2]).text();
        var name = sig;
        var me = (function (){
            var $v6 = new SharpKit.Google.ApiGenerator.Property();
            $v6.Name = name;
            $v6.Type = (function (){
                var $v7 = new SharpKit.Google.ApiGenerator.Class();
                $v7.Name = type;
                return $v7;
            })();
            $v6.Description = desc;
            return $v6;
        })();
        list.push(me);
    }
    return list;
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseEvents = function (tbl){
    var list =  [];
    var trs = $(tbl).find("> tbody > tr");
    for (var $i18 = 0,$l18 = trs.length,tr = trs[$i18]; $i18 < $l18; $i18++, tr = trs[$i18]){
        var cells = $(tr).children("td");
        var sig = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace($(cells[0]).text());
        var type = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace($(cells[1]).text());
        var desc = $(cells[2]).text();
        if (SharpKit.Google.ApiGenerator.Extensions.Contains(type, "None"))
            type = "JsAction";
        else
            type = "JsAction<" + type + ">";
        var name = sig;
        var me = (function (){
            var $v8 = new SharpKit.Google.ApiGenerator.Property();
            $v8.Name = name;
            $v8.Type = (function (){
                var $v9 = new SharpKit.Google.ApiGenerator.Class();
                $v9.Name = type;
                return $v9;
            })();
            $v8.Description = desc;
            return $v8;
        })();
        list.push(me);
    }
    return list;
};
SharpKit.Google.ApiGenerator.GoogleMapsParser.ParseMethods = function (tbl, isCtor){
    var list =  [];
    var trs = $(tbl).find("> tbody > tr");
    for (var $i19 = 0,$l19 = trs.length,tr = trs[$i19]; $i19 < $l19; $i19++, tr = trs[$i19]){
        var cells = $(tr).children("td");
        var sig = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace($(cells[0]).text());
        var type;
        var desc;
        if (isCtor){
            type = "";
            desc = $(cells[1]).text();
        }
        else {
            type = SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace($(cells[1]).text());
            desc = $(cells[2]).text();
        }
        var name = sig.substr(0, sig.indexOf("("));
        var me = (function (){
            var $v10 = new SharpKit.Google.ApiGenerator.Method();
            $v10.Name = name;
            $v10.Type = (function (){
                var $v11 = new SharpKit.Google.ApiGenerator.Class();
                $v11.Name = type;
                return $v11;
            })();
            $v10.Description = desc;
            $v10.IsConstructor = isCtor;
            return $v10;
        })();
        var prms = sig.substr(sig.indexOf("(") + 1);
        prms = prms.substr(0, prms.indexOf(")"));
        if (prms.length > 0){
            if (!SharpKit.Google.ApiGenerator.Extensions.Contains(prms, "function")){
                var prms2 = prms.split(",");
                for (var $i20 = 0,$l20 = prms2.length,prm = prms2[$i20]; $i20 < $l20; $i20++, prm = prms2[$i20]){
                    var tokens = prm.split(":");
                    var prmTypeName = (tokens[1] != null ? tokens[1] : "").trim();
                    var prmName = tokens[0].trim();
                    var prm3 = (function (){
                        var $v12 = new SharpKit.Google.ApiGenerator.Parameter();
                        $v12.Type = (function (){
                            var $v13 = new SharpKit.Google.ApiGenerator.Class();
                            $v13.Name = (prmTypeName != null ? prmTypeName : "object");
                            return $v13;
                        })();
                        return $v12;
                    })();
                    if (SharpKit.Google.ApiGenerator.Extensions.EndsWith(prmName, "?")){
                        prmName = prmName.substr(0, prmName.length - 1);
                        prm3.IsOptional = true;
                    }
                    prm3.Name = prmName;
                    me.Parameters.push(prm3);
                }
            }
        }
        list.push(me);
    }
    return list;
};
SharpKit.Google.ApiGenerator.CodeWriter = function (){
    this.Writer = null;
    this.Writer =  [];
};
SharpKit.Google.ApiGenerator.CodeWriter.prototype.BeginBlock = function (){
    this.WriteLine("{");
};
SharpKit.Google.ApiGenerator.CodeWriter.prototype.EndBlock = function (){
    this.WriteLine("}");
};
SharpKit.Google.ApiGenerator.CodeWriter.prototype.WriteLine = function (obj){
    if (obj == null)
        return;
    this.Write(obj + "\n");
};
SharpKit.Google.ApiGenerator.CodeWriter.prototype.toString = function (){
    return this.Writer.join("");
};
SharpKit.Google.ApiGenerator.CodeWriter.prototype.Write = function (s){
    this.Writer.push(s);
};
SharpKit.Google.ApiGenerator.Extensions = function (){
};
SharpKit.Google.ApiGenerator.Extensions.Contains = function (s, find){
    return s.indexOf(find) >= 0;
};
SharpKit.Google.ApiGenerator.Extensions.StartsWith = function (s, find){
    return s.indexOf(find) == 0;
};
SharpKit.Google.ApiGenerator.Extensions.EndsWith = function (s, find){
    return s.lastIndexOf(find) == s.length - find.length;
};
SharpKit.Google.ApiGenerator.Extensions.JsSelect = function (list, selector){
    var list2 =  [];
    for (var $i21 = 0,$l21 = list.length,item = list[$i21]; $i21 < $l21; $i21++, item = list[$i21])
        list2.push(selector(item));
    return list2;
};
SharpKit.Google.ApiGenerator.Extensions.RemoveWhitespace = function (s){
    return s.replace(new RegExp("\\s", "g"), "");
};
SharpKit.Google.ApiGenerator.Extensions.RemoveLast = function (s, find){
    var index = s.lastIndexOf(find);
    if (index >= 0)
        return s.substring(0, index) + s.substring(index + find.length);
    return s;
};
SharpKit.Google.ApiGenerator.Assembly = function (){
    this.Classes = null;
    this.Classes =  [];
};
SharpKit.Google.ApiGenerator.Member = function (){
    this.Type = null;
    this.Name = null;
    this.Description = null;
    this.Attributes = null;
    this.Attributes =  [];
};
SharpKit.Google.ApiGenerator.Attribute = function (){
    this.Code = null;
};
SharpKit.Google.ApiGenerator.Method = function (){
    this.IsConstructor = false;
    this.Parameters = null;
    SharpKit.Google.ApiGenerator.Member.call(this);
    this.Parameters =  [];
};
$Inherit(SharpKit.Google.ApiGenerator.Method, SharpKit.Google.ApiGenerator.Member);
SharpKit.Google.ApiGenerator.Property = function (){
    this.IsStatic = false;
    SharpKit.Google.ApiGenerator.Member.call(this);
};
$Inherit(SharpKit.Google.ApiGenerator.Property, SharpKit.Google.ApiGenerator.Member);
SharpKit.Google.ApiGenerator.Parameter = function (){
    this.IsOptional = false;
    SharpKit.Google.ApiGenerator.Member.call(this);
};
$Inherit(SharpKit.Google.ApiGenerator.Parameter, SharpKit.Google.ApiGenerator.Member);
SharpKit.Google.ApiGenerator.Class = function (){
    this.Members = null;
    this.Namespace = null;
    SharpKit.Google.ApiGenerator.Member.call(this);
};
$Inherit(SharpKit.Google.ApiGenerator.Class, SharpKit.Google.ApiGenerator.Member);

