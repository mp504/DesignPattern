using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IDocumentState
    {
        void Edit(Document document);
        void Review(Document document);
        void Approve(Document document);
        void Publish(Document document);
    }

    public class DraftState : IDocumentState
    {
        public void Edit(Document document)
        {
            Console.WriteLine("Document is being edited in Draft state.");
        }

        public void Review(Document document)
        {
            Console.WriteLine("Document is sent for review.");
            document.SetState(new ReviewState());
        }

        public void Approve(Document document)
        {
            Console.WriteLine("Draft must be reviewed before approval.");
        }

        public void Publish(Document document)
        {
            Console.WriteLine("Draft must be reviewed and approved before publishing.");
        }
    }

    public class ReviewState : IDocumentState
    {
        public void Edit(Document document)
        {
            Console.WriteLine("Document is under review and cannot be edited.");
        }

        public void Review(Document document)
        {
            Console.WriteLine("Document is already under review.");
        }

        public void Approve(Document document)
        {
            Console.WriteLine("Document is approved.");
            document.SetState(new ApprovedState());
        }

        public void Publish(Document document)
        {
            Console.WriteLine("Document must be approved before publishing.");
        }
    }

    public class ApprovedState : IDocumentState
    {
        public void Edit(Document document)
        {
            Console.WriteLine("Approved document cannot be edited.");
        }

        public void Review(Document document)
        {
            Console.WriteLine("Document is already approved and cannot be reviewed again.");
        }

        public void Approve(Document document)
        {
            Console.WriteLine("Document is already approved.");
        }

        public void Publish(Document document)
        {
            Console.WriteLine("Document is published.");
            document.SetState(new PublishedState());
        }
    }

    public class PublishedState : IDocumentState
    {
        public void Edit(Document document)
        {
            Console.WriteLine("Published document cannot be edited.");
        }

        public void Review(Document document)
        {
            Console.WriteLine("Published document cannot be reviewed.");
        }

        public void Approve(Document document)
        {
            Console.WriteLine("Published document cannot be approved.");
        }

        public void Publish(Document document)
        {
            Console.WriteLine("Document is already published.");
        }
    }



    public class Document
    {
        private IDocumentState _state;

        public Document()
        {
            _state = new DraftState(); 
        }

        public void SetState(IDocumentState state)
        {
            _state = state;
        }

        public void Edit()
        {
            _state.Edit(this);
        }

        public void Review()
        {
            _state.Review(this);
        }

        public void Approve()
        {
            _state.Approve(this);
        }

        public void Publish()
        {
            _state.Publish(this);
        }
    }
    




}
