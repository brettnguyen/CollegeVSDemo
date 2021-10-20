using System;
using Lottie.Forms;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public class StartLottieAnimationTriggerAction : TriggerAction<AnimationView>
    {
        protected override void Invoke(AnimationView sender)
        {
            sender.PlayAnimation();
        }
    }
}
