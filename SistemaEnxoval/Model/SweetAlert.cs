namespace SistemaEnxoval.Model
{
    public class SweetAlert
    {
        public string Title { get; set; } = "Alerta";
        public string Text { get; set; } = string.Empty;
        public string Icon { get; set; } = "Success";
        public string ButtonText { get; set; } = "Ok";
        public bool Show { get; set; } = false;

        public SweetAlert()
        {

        }

    }
}
