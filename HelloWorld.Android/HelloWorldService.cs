﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by SlSvcUtil, version 5.0.61118.0
// 
namespace HelloWorldWcfHost
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HelloWorldData", Namespace="http://schemas.datacontract.org/2004/07/HelloWorldWcfHost")]
    public partial class HelloWorldData : object
    {
        
        private string NameField;
        
        private bool SayHelloField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SayHello
        {
            get
            {
                return this.SayHelloField;
            }
            set
            {
                this.SayHelloField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IHelloWorldService")]
public interface IHelloWorldService
{
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IHelloWorldService/SayHelloTo", ReplyAction="http://tempuri.org/IHelloWorldService/SayHelloToResponse")]
    System.IAsyncResult BeginSayHelloTo(string name, System.AsyncCallback callback, object asyncState);
    
    string EndSayHelloTo(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IHelloWorldService/GetHelloData", ReplyAction="http://tempuri.org/IHelloWorldService/GetHelloDataResponse")]
    System.IAsyncResult BeginGetHelloData(HelloWorldWcfHost.HelloWorldData helloWorldData, System.AsyncCallback callback, object asyncState);
    
    HelloWorldWcfHost.HelloWorldData EndGetHelloData(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IHelloWorldService/NameList", ReplyAction="http://tempuri.org/IHelloWorldService/NameListResponse")]
    System.IAsyncResult BeginNameList(string[] name, System.AsyncCallback callback, object asyncState);
    
    string[] EndNameList(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IHelloWorldService/ProcessImage", ReplyAction="http://tempuri.org/IHelloWorldService/ProcessImageResponse")]
    System.IAsyncResult BeginProcessImage(byte[] byteArray, System.AsyncCallback callback, object asyncState);
    
    byte[] EndProcessImage(System.IAsyncResult result);
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IHelloWorldService/Recognize", ReplyAction="http://tempuri.org/IHelloWorldService/RecognizeResponse")]
    System.IAsyncResult BeginRecognize(byte[] byteArray, System.AsyncCallback callback, object asyncState);
    
    string[] EndRecognize(System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IHelloWorldServiceChannel : IHelloWorldService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SayHelloToCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public SayHelloToCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public string Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GetHelloDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public GetHelloDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public HelloWorldWcfHost.HelloWorldData Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((HelloWorldWcfHost.HelloWorldData)(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class NameListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public NameListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public string[] Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((string[])(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ProcessImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public ProcessImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public byte[] Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((byte[])(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class RecognizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{
    
    private object[] results;
    
    public RecognizeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState)
    {
        this.results = results;
    }
    
    public string[] Result
    {
        get
        {
            base.RaiseExceptionIfNecessary();
            return ((string[])(this.results[0]));
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class HelloWorldServiceClient : System.ServiceModel.ClientBase<IHelloWorldService>, IHelloWorldService
{
    
    private BeginOperationDelegate onBeginSayHelloToDelegate;
    
    private EndOperationDelegate onEndSayHelloToDelegate;
    
    private System.Threading.SendOrPostCallback onSayHelloToCompletedDelegate;
    
    private BeginOperationDelegate onBeginGetHelloDataDelegate;
    
    private EndOperationDelegate onEndGetHelloDataDelegate;
    
    private System.Threading.SendOrPostCallback onGetHelloDataCompletedDelegate;
    
    private BeginOperationDelegate onBeginNameListDelegate;
    
    private EndOperationDelegate onEndNameListDelegate;
    
    private System.Threading.SendOrPostCallback onNameListCompletedDelegate;
    
    private BeginOperationDelegate onBeginProcessImageDelegate;
    
    private EndOperationDelegate onEndProcessImageDelegate;
    
    private System.Threading.SendOrPostCallback onProcessImageCompletedDelegate;
    
    private BeginOperationDelegate onBeginRecognizeDelegate;
    
    private EndOperationDelegate onEndRecognizeDelegate;
    
    private System.Threading.SendOrPostCallback onRecognizeCompletedDelegate;
    
    private BeginOperationDelegate onBeginOpenDelegate;
    
    private EndOperationDelegate onEndOpenDelegate;
    
    private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
    
    private BeginOperationDelegate onBeginCloseDelegate;
    
    private EndOperationDelegate onEndCloseDelegate;
    
    private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    
    public HelloWorldServiceClient()
    {
    }
    
    public HelloWorldServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public HelloWorldServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HelloWorldServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HelloWorldServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Net.CookieContainer CookieContainer
    {
        get
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                return httpCookieContainerManager.CookieContainer;
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
            if ((httpCookieContainerManager != null))
            {
                httpCookieContainerManager.CookieContainer = value;
            }
            else
            {
                throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                        "ookieContainerBindingElement.");
            }
        }
    }
    
    public event System.EventHandler<SayHelloToCompletedEventArgs> SayHelloToCompleted;
    
    public event System.EventHandler<GetHelloDataCompletedEventArgs> GetHelloDataCompleted;
    
    public event System.EventHandler<NameListCompletedEventArgs> NameListCompleted;
    
    public event System.EventHandler<ProcessImageCompletedEventArgs> ProcessImageCompleted;
    
    public event System.EventHandler<RecognizeCompletedEventArgs> RecognizeCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    
    public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IHelloWorldService.BeginSayHelloTo(string name, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginSayHelloTo(name, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    string IHelloWorldService.EndSayHelloTo(System.IAsyncResult result)
    {
        return base.Channel.EndSayHelloTo(result);
    }
    
    private System.IAsyncResult OnBeginSayHelloTo(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        string name = ((string)(inValues[0]));
        return ((IHelloWorldService)(this)).BeginSayHelloTo(name, callback, asyncState);
    }
    
    private object[] OnEndSayHelloTo(System.IAsyncResult result)
    {
        string retVal = ((IHelloWorldService)(this)).EndSayHelloTo(result);
        return new object[] {
                retVal};
    }
    
    private void OnSayHelloToCompleted(object state)
    {
        if ((this.SayHelloToCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.SayHelloToCompleted(this, new SayHelloToCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void SayHelloToAsync(string name)
    {
        this.SayHelloToAsync(name, null);
    }
    
    public void SayHelloToAsync(string name, object userState)
    {
        if ((this.onBeginSayHelloToDelegate == null))
        {
            this.onBeginSayHelloToDelegate = new BeginOperationDelegate(this.OnBeginSayHelloTo);
        }
        if ((this.onEndSayHelloToDelegate == null))
        {
            this.onEndSayHelloToDelegate = new EndOperationDelegate(this.OnEndSayHelloTo);
        }
        if ((this.onSayHelloToCompletedDelegate == null))
        {
            this.onSayHelloToCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSayHelloToCompleted);
        }
        base.InvokeAsync(this.onBeginSayHelloToDelegate, new object[] {
                    name}, this.onEndSayHelloToDelegate, this.onSayHelloToCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IHelloWorldService.BeginGetHelloData(HelloWorldWcfHost.HelloWorldData helloWorldData, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetHelloData(helloWorldData, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    HelloWorldWcfHost.HelloWorldData IHelloWorldService.EndGetHelloData(System.IAsyncResult result)
    {
        return base.Channel.EndGetHelloData(result);
    }
    
    private System.IAsyncResult OnBeginGetHelloData(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        HelloWorldWcfHost.HelloWorldData helloWorldData = ((HelloWorldWcfHost.HelloWorldData)(inValues[0]));
        return ((IHelloWorldService)(this)).BeginGetHelloData(helloWorldData, callback, asyncState);
    }
    
    private object[] OnEndGetHelloData(System.IAsyncResult result)
    {
        HelloWorldWcfHost.HelloWorldData retVal = ((IHelloWorldService)(this)).EndGetHelloData(result);
        return new object[] {
                retVal};
    }
    
    private void OnGetHelloDataCompleted(object state)
    {
        if ((this.GetHelloDataCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.GetHelloDataCompleted(this, new GetHelloDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void GetHelloDataAsync(HelloWorldWcfHost.HelloWorldData helloWorldData)
    {
        this.GetHelloDataAsync(helloWorldData, null);
    }
    
    public void GetHelloDataAsync(HelloWorldWcfHost.HelloWorldData helloWorldData, object userState)
    {
        if ((this.onBeginGetHelloDataDelegate == null))
        {
            this.onBeginGetHelloDataDelegate = new BeginOperationDelegate(this.OnBeginGetHelloData);
        }
        if ((this.onEndGetHelloDataDelegate == null))
        {
            this.onEndGetHelloDataDelegate = new EndOperationDelegate(this.OnEndGetHelloData);
        }
        if ((this.onGetHelloDataCompletedDelegate == null))
        {
            this.onGetHelloDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetHelloDataCompleted);
        }
        base.InvokeAsync(this.onBeginGetHelloDataDelegate, new object[] {
                    helloWorldData}, this.onEndGetHelloDataDelegate, this.onGetHelloDataCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IHelloWorldService.BeginNameList(string[] name, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginNameList(name, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    string[] IHelloWorldService.EndNameList(System.IAsyncResult result)
    {
        return base.Channel.EndNameList(result);
    }
    
    private System.IAsyncResult OnBeginNameList(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        string[] name = ((string[])(inValues[0]));
        return ((IHelloWorldService)(this)).BeginNameList(name, callback, asyncState);
    }
    
    private object[] OnEndNameList(System.IAsyncResult result)
    {
        string[] retVal = ((IHelloWorldService)(this)).EndNameList(result);
        return new object[] {
                retVal};
    }
    
    private void OnNameListCompleted(object state)
    {
        if ((this.NameListCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.NameListCompleted(this, new NameListCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void NameListAsync(string[] name)
    {
        this.NameListAsync(name, null);
    }
    
    public void NameListAsync(string[] name, object userState)
    {
        if ((this.onBeginNameListDelegate == null))
        {
            this.onBeginNameListDelegate = new BeginOperationDelegate(this.OnBeginNameList);
        }
        if ((this.onEndNameListDelegate == null))
        {
            this.onEndNameListDelegate = new EndOperationDelegate(this.OnEndNameList);
        }
        if ((this.onNameListCompletedDelegate == null))
        {
            this.onNameListCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnNameListCompleted);
        }
        base.InvokeAsync(this.onBeginNameListDelegate, new object[] {
                    name}, this.onEndNameListDelegate, this.onNameListCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IHelloWorldService.BeginProcessImage(byte[] byteArray, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginProcessImage(byteArray, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    byte[] IHelloWorldService.EndProcessImage(System.IAsyncResult result)
    {
        return base.Channel.EndProcessImage(result);
    }
    
    private System.IAsyncResult OnBeginProcessImage(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        byte[] byteArray = ((byte[])(inValues[0]));
        return ((IHelloWorldService)(this)).BeginProcessImage(byteArray, callback, asyncState);
    }
    
    private object[] OnEndProcessImage(System.IAsyncResult result)
    {
        byte[] retVal = ((IHelloWorldService)(this)).EndProcessImage(result);
        return new object[] {
                retVal};
    }
    
    private void OnProcessImageCompleted(object state)
    {
        if ((this.ProcessImageCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.ProcessImageCompleted(this, new ProcessImageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void ProcessImageAsync(byte[] byteArray)
    {
        this.ProcessImageAsync(byteArray, null);
    }
    
    public void ProcessImageAsync(byte[] byteArray, object userState)
    {
        if ((this.onBeginProcessImageDelegate == null))
        {
            this.onBeginProcessImageDelegate = new BeginOperationDelegate(this.OnBeginProcessImage);
        }
        if ((this.onEndProcessImageDelegate == null))
        {
            this.onEndProcessImageDelegate = new EndOperationDelegate(this.OnEndProcessImage);
        }
        if ((this.onProcessImageCompletedDelegate == null))
        {
            this.onProcessImageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnProcessImageCompleted);
        }
        base.InvokeAsync(this.onBeginProcessImageDelegate, new object[] {
                    byteArray}, this.onEndProcessImageDelegate, this.onProcessImageCompletedDelegate, userState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IHelloWorldService.BeginRecognize(byte[] byteArray, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginRecognize(byteArray, callback, asyncState);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    string[] IHelloWorldService.EndRecognize(System.IAsyncResult result)
    {
        return base.Channel.EndRecognize(result);
    }
    
    private System.IAsyncResult OnBeginRecognize(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        byte[] byteArray = ((byte[])(inValues[0]));
        return ((IHelloWorldService)(this)).BeginRecognize(byteArray, callback, asyncState);
    }
    
    private object[] OnEndRecognize(System.IAsyncResult result)
    {
        string[] retVal = ((IHelloWorldService)(this)).EndRecognize(result);
        return new object[] {
                retVal};
    }
    
    private void OnRecognizeCompleted(object state)
    {
        if ((this.RecognizeCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.RecognizeCompleted(this, new RecognizeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void RecognizeAsync(byte[] byteArray)
    {
        this.RecognizeAsync(byteArray, null);
    }
    
    public void RecognizeAsync(byte[] byteArray, object userState)
    {
        if ((this.onBeginRecognizeDelegate == null))
        {
            this.onBeginRecognizeDelegate = new BeginOperationDelegate(this.OnBeginRecognize);
        }
        if ((this.onEndRecognizeDelegate == null))
        {
            this.onEndRecognizeDelegate = new EndOperationDelegate(this.OnEndRecognize);
        }
        if ((this.onRecognizeCompletedDelegate == null))
        {
            this.onRecognizeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRecognizeCompleted);
        }
        base.InvokeAsync(this.onBeginRecognizeDelegate, new object[] {
                    byteArray}, this.onEndRecognizeDelegate, this.onRecognizeCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
    }
    
    private object[] OnEndOpen(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
        return null;
    }
    
    private void OnOpenCompleted(object state)
    {
        if ((this.OpenCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void OpenAsync()
    {
        this.OpenAsync(null);
    }
    
    public void OpenAsync(object userState)
    {
        if ((this.onBeginOpenDelegate == null))
        {
            this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
        }
        if ((this.onEndOpenDelegate == null))
        {
            this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
        }
        if ((this.onOpenCompletedDelegate == null))
        {
            this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
        }
        base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
    }
    
    private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
    {
        return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
    }
    
    private object[] OnEndClose(System.IAsyncResult result)
    {
        ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
        return null;
    }
    
    private void OnCloseCompleted(object state)
    {
        if ((this.CloseCompleted != null))
        {
            InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
            this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
        }
    }
    
    public void CloseAsync()
    {
        this.CloseAsync(null);
    }
    
    public void CloseAsync(object userState)
    {
        if ((this.onBeginCloseDelegate == null))
        {
            this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
        }
        if ((this.onEndCloseDelegate == null))
        {
            this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
        }
        if ((this.onCloseCompletedDelegate == null))
        {
            this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
        }
        base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
    }
    
    protected override IHelloWorldService CreateChannel()
    {
        return new HelloWorldServiceClientChannel(this);
    }
    
    private class HelloWorldServiceClientChannel : ChannelBase<IHelloWorldService>, IHelloWorldService
    {
        
        public HelloWorldServiceClientChannel(System.ServiceModel.ClientBase<IHelloWorldService> client) : 
                base(client)
        {
        }
        
        public System.IAsyncResult BeginSayHelloTo(string name, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = name;
            System.IAsyncResult _result = base.BeginInvoke("SayHelloTo", _args, callback, asyncState);
            return _result;
        }
        
        public string EndSayHelloTo(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            string _result = ((string)(base.EndInvoke("SayHelloTo", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginGetHelloData(HelloWorldWcfHost.HelloWorldData helloWorldData, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = helloWorldData;
            System.IAsyncResult _result = base.BeginInvoke("GetHelloData", _args, callback, asyncState);
            return _result;
        }
        
        public HelloWorldWcfHost.HelloWorldData EndGetHelloData(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            HelloWorldWcfHost.HelloWorldData _result = ((HelloWorldWcfHost.HelloWorldData)(base.EndInvoke("GetHelloData", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginNameList(string[] name, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = name;
            System.IAsyncResult _result = base.BeginInvoke("NameList", _args, callback, asyncState);
            return _result;
        }
        
        public string[] EndNameList(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            string[] _result = ((string[])(base.EndInvoke("NameList", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginProcessImage(byte[] byteArray, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = byteArray;
            System.IAsyncResult _result = base.BeginInvoke("ProcessImage", _args, callback, asyncState);
            return _result;
        }
        
        public byte[] EndProcessImage(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            byte[] _result = ((byte[])(base.EndInvoke("ProcessImage", _args, result)));
            return _result;
        }
        
        public System.IAsyncResult BeginRecognize(byte[] byteArray, System.AsyncCallback callback, object asyncState)
        {
            object[] _args = new object[1];
            _args[0] = byteArray;
            System.IAsyncResult _result = base.BeginInvoke("Recognize", _args, callback, asyncState);
            return _result;
        }
        
        public string[] EndRecognize(System.IAsyncResult result)
        {
            object[] _args = new object[0];
            string[] _result = ((string[])(base.EndInvoke("Recognize", _args, result)));
            return _result;
        }
    }
}
