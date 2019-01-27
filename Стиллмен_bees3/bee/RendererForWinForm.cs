namespace bee
{
    public class RendererForWinForm: Renderer
    {
        private HiveForm hiveForm;
        private FieldForm fieldForm;
        public RendererForWinForm(World world, HiveForm hiveForm, FieldForm fieldForm):base(world)
        {
            this.hiveForm = hiveForm;
            this.fieldForm = fieldForm;
            hiveForm.Renderer = this;
            fieldForm.Renderer = this;
            InitializeImages();
        }
// HiveOutside = ResizeImage(Properties.Resources._6, 45,60);
// hiveForm.Invalidate();  fieldForm.Invalidate();
    }
}


