namespace Sandbox
{
    using Simple.Web;

    [UriTemplate("/submit")]
    public class SubmitEndpoint : PostEndpoint<Form,string>
    {
        protected override string Get()
        {
            return string.Format("Posted value: {0}!", Model.Text);
        }
    }
}