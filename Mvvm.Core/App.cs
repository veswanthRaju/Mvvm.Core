using MvvmCross.Platform.IoC;

namespace Mvvm.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            //This will startup the application (By loading particular view model)
            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}
