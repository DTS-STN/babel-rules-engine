using esdc_rules_classes;

namespace esdc_rules_api.Lib
{
    // TODO: Can remove this
    public interface ICalculateRules<T,U>
        where T : IRule
        where U : IRulePerson
    {
        decimal Calculate(T rule, U person);
    }
}