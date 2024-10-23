using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{

    public class Document
    {
        public bool Complete { get; set; }
        public bool Necessary { get; set; }
        public bool FinanciallyCompliant { get; set; }
    }

    public abstract class DocumentHandler
    {
        protected DocumentHandler _nextHandler;

        public DocumentHandler SetNext(DocumentHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return nextHandler;
        }
        public virtual string Handle(Document document)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(document);
            }
            return "No handler available";
        }
    }

    public class InitialReviewHandler : DocumentHandler
    {
        public override string Handle(Document document)
        {
            if (document.Complete)
            {
                return base.Handle(document);
            }
            else
            {
                return "Document incomplete, cannot proceed.";
            }
        }
    }

    public class DepartmentHeadHandler : DocumentHandler
    {
        public override string Handle(Document document)
        {
            if (document.Necessary)
            {
                return base.Handle(document);
            }
            else
            {
                return "Document not necessary, rejected.";
            }
        }
    }

    public class FinanceHandler : DocumentHandler
    {
        public override string Handle(Document document)
        {
            if (document.FinanciallyCompliant)
            {
                return "Document approved.";
            }
            else
            {
                return "Document rejected due to financial issues.";
            }
        }
    }


}