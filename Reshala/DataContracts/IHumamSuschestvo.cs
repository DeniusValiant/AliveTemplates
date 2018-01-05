namespace Reshala.DataContracts
{
    public interface IHumamSuschestvo
    {
        void NaytyReshalu(IReshala2 r);
        void Poprosit(IVopros v);
        void Execute(IVopros v, double _t);
    }
}