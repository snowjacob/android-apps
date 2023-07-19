using Android.App;
using Android.OS;
using Android.Widget;

namespace ChecklistApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private CheckboxManager checkboxManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            LinearLayout linearLayout = FindViewById<LinearLayout>(Resource.Id.checkboxLayout);
            EditText inputEditText = FindViewById<EditText>(Resource.Id.inputEditText);

            checkboxManager = new CheckboxManager(linearLayout, inputEditText);

            Button addNoteButton = FindViewById<Button>(Resource.Id.addNoteButton);
            addNoteButton.Click += AddNoteButton_Click;
        }

        private void AddNoteButton_Click(object sender, System.EventArgs e)
        {
            checkboxManager.AddCheckbox();
        }
    }
}
