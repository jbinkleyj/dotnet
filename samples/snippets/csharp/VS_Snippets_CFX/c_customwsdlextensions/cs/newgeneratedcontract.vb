'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization

' <snippet13>

'''From WSDL Documentation:
'''
'''<summary>This contract is a stateless contract that provides a mechanism for 
'''computing the nth Fibonacci term.</summary> 
'''
<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
 System.ServiceModel.ServiceContractAttribute([Namespace]:="http://microsoft.wcf.documentation", ConfigurationName:="IFibonacci")>  _
Public Interface IFibonacci
    
    '''From WSDL Documentation:
    '''
    '''<summary>The Compute operation returns the nth Fibonacci number.  Because it 
    '''uses dual recursion it's very inefficient and therefore useful to demonstrate 
    '''caching.</summary><returns>The nth Fibonacci number.</returns><param 
    '''name="num">The value to use when computing the Fibonacci number.</param> 
    '''
    <System.ServiceModel.OperationContractAttribute(Action:="http://microsoft.wcf.documentation/IFibonacci/Compute", ReplyAction:="http://microsoft.wcf.documentation/IFibonacci/ComputeResponse")>  _
    Function Compute(ByVal num As Integer) As Integer
    
    '''From WSDL Documentation:
    '''
    '''<summary>The GetPerson operation tests custom WSDL documentation 
    '''generation.</summary><returns>The Person object to be returned.</returns><param 
    '''name="FirstParameter">The value for the first parameter.</param><param 
    '''name="SecondParameter">The value for the second parameter.</param> 
    '''
    <System.ServiceModel.OperationContractAttribute(Action:="http://microsoft.wcf.documentation/IFibonacci/GetPerson", ReplyAction:="http://microsoft.wcf.documentation/IFibonacci/GetPersonResponse")>  _
    Function GetPerson(ByVal FirstParameter As Integer, ByVal SecondParameter As Integer) As Microsoft.WCF.Documentation.Person
End Interface
' </snippet13>


<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
Public Interface IFibonacciChannel
    Inherits IFibonacci, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(),  _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
Partial Public Class FibonacciClient
    Inherits System.ServiceModel.ClientBase(Of IFibonacci)
    Implements IFibonacci
    
    Public Sub New()
        MyBase.New
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String)
        MyBase.New(endpointConfigurationName)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(binding, remoteAddress)
    End Sub
    
    Public Function Compute(ByVal num As Integer) As Integer Implements IFibonacci.Compute
        Return MyBase.Channel.Compute(num)
    End Function
    
    Public Function GetPerson(ByVal FirstParameter As Integer, ByVal SecondParameter As Integer) As Microsoft.WCF.Documentation.Person Implements IFibonacci.GetPerson
        Return MyBase.Channel.GetPerson(FirstParameter, SecondParameter)
    End Function
End Class

Namespace Microsoft.WCF.Documentation
    
    '''From WSDL Documentation:
    '''
    '''<summary>The string for the Person type.</summary> 
    '''
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class Person
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private NameField As String
        
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
    ' <snippet3>

        '''From WSDL Documentation:
        '''
        '''<summary>The string for the Name data member.</summary> 
        '''
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
    ' </snippet3>
  End Class
End Namespace
