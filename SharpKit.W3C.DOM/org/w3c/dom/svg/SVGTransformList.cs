//AutoGenerated

namespace org.w3c.dom.svg
{

    using DOMException = org.w3c.dom.DOMException;

    public interface SVGTransformList
    {
        // SVGTransformList
        int numberOfItems {get;}
//TODO:
//ORIGINAL LINE: public void clear() throws org.w3c.dom.DOMException;
        void clear();
//TODO:
//ORIGINAL LINE: public SVGTransform initialize(SVGTransform newItem) throws org.w3c.dom.DOMException, SVGException;
        SVGTransform initialize(SVGTransform newItem);
//TODO:
//ORIGINAL LINE: public SVGTransform getItem(int index) throws org.w3c.dom.DOMException;
        SVGTransform getItem(int index);
//TODO:
//ORIGINAL LINE: public SVGTransform insertItemBefore(SVGTransform newItem, int index) throws org.w3c.dom.DOMException, SVGException;
        SVGTransform insertItemBefore(SVGTransform newItem, int index);
//TODO:
//ORIGINAL LINE: public SVGTransform replaceItem(SVGTransform newItem, int index) throws org.w3c.dom.DOMException, SVGException;
        SVGTransform replaceItem(SVGTransform newItem, int index);
//TODO:
//ORIGINAL LINE: public SVGTransform removeItem(int index) throws org.w3c.dom.DOMException;
        SVGTransform removeItem(int index);
//TODO:
//ORIGINAL LINE: public SVGTransform appendItem(SVGTransform newItem) throws org.w3c.dom.DOMException, SVGException;
        SVGTransform appendItem(SVGTransform newItem);
        SVGTransform createSVGTransformFromMatrix(SVGMatrix matrix);
        SVGTransform consolidate();
    }

}