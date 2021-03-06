#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"PrimitiveOperationsCounter\",\"Name\":\"PrimitiveOperationsChecker\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/PrimitiveOperationsCounter/Quantum.qs\",\"Position\":{\"Item1\":15,\"Item2\":3},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[\" PrimitiveOperationsChecker Operation\",\" # Summary\",\" executes CCNOT Gate\",\" # Parameters\",\" # Returns\",\" unit\"]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"PrimitiveOperationsCounter\",\"Name\":\"PrimitiveOperationsChecker\"},\"SourceFile\":\"/Users/bhagvan.kommadi/Desktop/packt/Q%23Book/Code/Chapter9/TraceSimulator/PrimitiveOperationsCounter/Quantum.qs\",\"Position\":{\"Item1\":16,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
#line hidden
namespace PrimitiveOperationsCounter
{
    public class PrimitiveOperationsChecker : Operation<QVoid, QVoid>, ICallable
    {
        public PrimitiveOperationsChecker(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PrimitiveOperationsChecker";
        String ICallable.FullName => "PrimitiveOperationsCounter.PrimitiveOperationsChecker";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveT
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 18 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/PrimitiveOperationsCounter/Quantum.qs"
                var qubits = Allocate.Apply(3L);
#line 19 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/PrimitiveOperationsCounter/Quantum.qs"
                MicrosoftQuantumPrimitiveCCNOT.Apply((qubits[0L], qubits[1L], qubits[2L]));
#line 20 "/Users/bhagvan.kommadi/Desktop/packt/Q#Book/Code/Chapter9/TraceSimulator/PrimitiveOperationsCounter/Quantum.qs"
                MicrosoftQuantumPrimitiveT.Apply(qubits[0L]);
#line hidden
                Release.Apply(qubits);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.T));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<PrimitiveOperationsChecker, QVoid, QVoid>(QVoid.Instance);
        }
    }
}