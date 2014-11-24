using System;
using System.Collections.Generic;
using System.Text;

namespace EatSmart.Services
{
    public class SuitableStuffFetcherService
    {
        public string GetDiet()
        {
            return 
@"The 5:2 diet is based on a principle known as intermittent fasting (IF) – where you eat normally five days a week and fast on the other two days. On top of losing weight, fans claim the 5:2 diet can improve lifespan, brain function and protect against conditions such as dementia and Alzheimer’s. However, evidence on the effectiveness of the 5:2 diet is limited when compared to other types of weight loss techniques. One 2010 study found that women placed on a 5:2 diet achieved similar levels of weight loss as women on a calorie-controlled diet and were also less likely to develop chronic diseases such as type 2 diabetes. A 2012 study suggested that the 5:2 model may help lower the risk of certain obesity-related cancers, such as breast cancer. If you are considering it then you should first talk to your GP to see if it is suitable for you. Not everyone can safely fast. Pros: Sticking to a regimen for two days a week is more achievable than seven days so you are more likely to persevere with this way of eating and successfully lose weight. Two days per week on a restricted diet can lead to greater reductions in body fat, insulin resistance and other chronic diseases. Cons: The non-restricted days do not mean unlimited feasting. While you don’t need to be as strict about your calorie consumption, you still need to make healthy choices and be physically active. Skipping meals could make you feel dizzy, irritable, give you headaches and make it hard to concentrate, which can affect work and other daily tasks. Other reported side effects are difficulties sleeping and daytime sleepiness, bad breath and dehydration. BDA verdict: The 5:2 is a simple way to reduce calorie intake. There are lots of versions of this diet, with some less safe than others. Many studies on intermittent fasting are short-term, involve small numbers of subjects, or are animal-based. If you choose to follow it, choose an evidence-based plan based on healthy, balanced eating and written by a dietitian like the ""2-Day Diet"". It’s vital for your health to avoid nutritional deficiencies, dehydration and overeating on non-fast days. Never attempt to delay or skip meals if you are pregnant, have had, or are prone to, eating disorders or diabetes.";
        }

        public Tuple<string, string> GetFood()
        {
            return new Tuple<string, string>
            (
                @"http://upload.wikimedia.org/wikipedia/commons/6/64/Pork_chops_served.jpg",
                "Pork Chops"
            );
        }
    }
}
