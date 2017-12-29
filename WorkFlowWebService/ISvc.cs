using System.ServiceModel;
using WorkFlowEngine.BLL;

namespace WorkFlowWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISvc" in both code and config file together.
    [ServiceContract]
    public interface ISvc
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        bool NewRequest(int systemID, int docID, int requestorID, int owner, int curSequenceID, int conditionID, RequestorChoice[] choiceList);

        [OperationContract]
        RequestorChoice Construct(int systemID, int documentID, int mainSequenceID, int conditionID);
        
    }
}
