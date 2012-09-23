/*Generated by SharpKit 5 v4.29.7000*/
if(typeof(JsTypes) == "undefined")
    var JsTypes=[];
var ClrModeSamples$DeepClone$ObjectCloner=
{
    fullname:"ClrModeSamples.DeepClone.ObjectCloner",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        CloneObject$1$$T:function(obj)
        {
            return new ClrModeSamples.DeepClone.ObjectCloner.ctor().Clone$$Object(obj);
        }
    },
    assemblyName:"ClrModeSamples",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        },
        Clone$$Object:function(obj)
        {
            return this.Clone$$Object$$CloneContext(obj,new ClrModeSamples.DeepClone.CloneContext.ctor());
        },
        Clone$$Object$$CloneContext:function(obj,context)
        {
            var type=typeof(obj);
            if(type == "object")
            {
                var obj2;
                if(context.get_Mappings().ContainsKey(obj))
                    obj2 = context.get_Mappings().get_Item$$TKey(obj);
                else
                    obj2 = this.CloneObject$$Object$$CloneContext(obj,context);
                return obj2;
            }
            else
            {
                return obj;
            }
        },
        CloneObject$$Object$$CloneContext:function(obj,context)
        {
            if(obj instanceof Array)
            {
                var arr2= [];
                context.get_Mappings().set_Item$$TKey(obj,arr2);
                for(var $i2=0,$l2=arr2.length,item=arr2[$i2];$i2 < $l2;$i2++,item = arr2[$i2])
                    arr2.push(this.Clone$$Object$$CloneContext(item,context));
                return arr2;
            }
            else if(Is(obj,System.Collections.IList.ctor))
            {
                var list=obj;
                var list2=System.Activator.CreateInstance$$Type(obj.GetType());
                context.get_Mappings().set_Item$$TKey(obj,list2);
                var $it2=list.GetEnumerator();
                while($it2.MoveNext())
                {
                    var item=$it2.get_Current();
                    list2.Add(this.Clone$$Object$$CloneContext(item,context));
                }
                return list2;
            }
            else if(obj instanceof Date.ctor)
            {
                return new Date(obj.valueOf());
            }
            else
            {
                var obj2=System.Activator.CreateInstance$$Type(obj.GetType());
                context.get_Mappings().set_Item$$TKey(obj,obj2);
                var json=obj;
                var json2=obj2;
                for(var p in json)
                {
                    json2[p] = this.Clone$$Object$$CloneContext(json[p],context);
                }
                return obj2;
            }
        }
    }
};
JsTypes.push(ClrModeSamples$DeepClone$ObjectCloner);
var ClrModeSamples$DeepClone$CloneContext=
{
    fullname:"ClrModeSamples.DeepClone.CloneContext",
    baseTypeName:"System.Object",
    assemblyName:"ClrModeSamples",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            this._Mappings = null;
            System.Object.ctor.call(this);
            this.set_Mappings(new System.Collections.Generic.Dictionary$2.ctor(System.Object.ctor,System.Object.ctor));
        },
        Mappings$$:"System.Collections.Generic.Dictionary`2[[System.Object],[System.Object]]",
        get_Mappings:function()
        {
            return this._Mappings;
        },
        set_Mappings:function(value)
        {
            this._Mappings = value;
        }
    }
};
JsTypes.push(ClrModeSamples$DeepClone$CloneContext);
