﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm.CalculatorRef.cs {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorRef.cs.calculatorSoap")]
    public interface calculatorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Substract", ReplyAction="*")]
        int Substract(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Substract", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubstractAsync(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiple", ReplyAction="*")]
        int Multiple(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiple", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultipleAsync(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        int Divide(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivideAsync(int firstNumber, int secondNumber);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface calculatorSoapChannel : WebForm.CalculatorRef.cs.calculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class calculatorSoapClient : System.ServiceModel.ClientBase<WebForm.CalculatorRef.cs.calculatorSoap>, WebForm.CalculatorRef.cs.calculatorSoap {
        
        public calculatorSoapClient() {
        }
        
        public calculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public calculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public calculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public calculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int firstNumber, int secondNumber) {
            return base.Channel.Add(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber) {
            return base.Channel.AddAsync(firstNumber, secondNumber);
        }
        
        public int Substract(int firstNumber, int secondNumber) {
            return base.Channel.Substract(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> SubstractAsync(int firstNumber, int secondNumber) {
            return base.Channel.SubstractAsync(firstNumber, secondNumber);
        }
        
        public int Multiple(int firstNumber, int secondNumber) {
            return base.Channel.Multiple(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> MultipleAsync(int firstNumber, int secondNumber) {
            return base.Channel.MultipleAsync(firstNumber, secondNumber);
        }
        
        public int Divide(int firstNumber, int secondNumber) {
            return base.Channel.Divide(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int firstNumber, int secondNumber) {
            return base.Channel.DivideAsync(firstNumber, secondNumber);
        }
    }
}
