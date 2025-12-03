using Microsoft.Build.Framework;

namespace Tasks
{
    public class MyCustomTask : Microsoft.Build.Utilities.Task
    {
        [Required]
        public ITaskItem[] StringArray { get; set; }

        public override bool Execute()
        {
            string[] stringArray = [.. StringArray.Select(ti => ti.ItemSpec)];
            Log.LogMessage(@"Passed arguments:");
            Log.LogMessage($@"- StringArray (length {StringArray.Length}): {string.Join(", ", stringArray)}");

            return true;
        }
    }
}
