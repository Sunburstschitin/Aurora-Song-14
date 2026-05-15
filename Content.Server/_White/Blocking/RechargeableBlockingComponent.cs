namespace Content.Server._White.Blocking;

[RegisterComponent]
public sealed partial class RechargeableBlockingComponent : Component
{
    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float DischargedRechargeRate = 1.33f;

    [DataField, ViewVariables(VVAccess.ReadWrite)]
    public float ChargedRechargeRate = 2f;

    // [ViewVariables] //Aurora's Song | This state has been the bane of my existence, good riddance.
    // public bool Discharged;
}
