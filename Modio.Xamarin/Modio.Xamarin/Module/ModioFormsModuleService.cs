using Modio.Core.Module;

namespace Modio.Xamarin.Module
{
    public class ModioFormsModuleService : UIModuleService
    {

        public ModioFormsModuleService(string name)
        {
            Name = name;
            MetaInfo = new BaseModuleMeta { HeadTitle = name };
        }

        public ModioFormsModuleService(IModuleMeta metaInfo)
        {
            MetaInfo = metaInfo;
        }

        public override string Name { get; }

        public override bool IsActive => throw new System.NotImplementedException();

        public override IModuleMeta MetaInfo { get; }
    }
}
