//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.feature
{
    #region Chunking
    /// <inheritdocs />
    /// <summary>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Chunking : Feature
    {
        public Chunking(ChunkingConfig config){}
        public Chunking(){}
        public Chunking(params object[] args){}
    }
    #endregion
    #region ChunkingConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ChunkingConfig : FeatureConfig
    {
        public ChunkingConfig(params object[] args){}
    }
    #endregion
    #region ChunkingEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ChunkingEvents : FeatureEvents
    {
        public ChunkingEvents(params object[] args){}
    }
    #endregion
}
