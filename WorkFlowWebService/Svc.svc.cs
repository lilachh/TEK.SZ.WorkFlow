using System.Collections.Generic;
using System.Web.Services;
using WorkFlowEngine.BLL;

namespace WorkFlowWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Svc" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Svc.svc or Svc.svc.cs at the Solution Explorer and start debugging.
    public class Svc : ISvc
    {
        public void DoWork()
        {
        }
        public bool NewRequest(int systemID, int docID, int requestorID, int owner, int curSequenceID, int conditionID, RequestorChoice[] choiceList)
        {
            List<RequestorChoice> choiceList2 = new List<RequestorChoice>();

            for (int i = 0; i < choiceList.Length; i++)
            {
                if (choiceList[i] != null)
                {
                    choiceList2.Add(choiceList[i]);
                }
            }

            return WorkFlowEngine.BLL.WorkFlow.NewRequest(systemID, docID, requestorID, owner, curSequenceID, conditionID, choiceList2);
        }

        public RequestorChoice Construct(int systemID, int documentID, int mainSequenceID, int conditionID)
        {
            RequestorChoice rc = new RequestorChoice(systemID, documentID, mainSequenceID, conditionID);
            return rc;
        }

    }
}
