using Android;
using Android.Views;
using Android.Widget;

namespace ChecklistApp
{
    public class CheckboxManager
    {
        private LinearLayout linearLayout;
        private EditText editText;
        private int checkboxCount = 0;

        public CheckboxManager(LinearLayout layout, EditText inputEditText)
        {
            linearLayout = layout;
            editText = inputEditText;
        }

        public void AddCheckbox()
        {
            checkboxCount++;

            CheckBox checkBox = new CheckBox(linearLayout.Context);
            checkBox.Text = editText.Text;

            ImageView trashImageView = new ImageView(linearLayout.Context);
            trashImageView.SetImageResource(Resource.Drawable.trash);

            LinearLayout.LayoutParams trashImageViewLayoutParams = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);
            trashImageViewLayoutParams.Gravity = GravityFlags.End | GravityFlags.CenterVertical;
            trashImageViewLayoutParams.SetMargins(0, 10, 0, 10); // Adjust the margins as needed
            trashImageView.LayoutParameters = trashImageViewLayoutParams;

            trashImageView.Click += (sender, e) =>
            {
                linearLayout.RemoveView(checkBox);
                linearLayout.RemoveView(trashImageView);
                checkboxCount--;
            };

            linearLayout.AddView(checkBox);
            linearLayout.AddView(trashImageView);
        }
    }
}
