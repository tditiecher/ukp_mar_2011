namespace nothinbutdotnetprep.utility.filtering
{
    public class NotCriteria<ItemToMatch> : Criteria<ItemToMatch>
    {
        readonly Criteria<ItemToMatch> criteria;

        public NotCriteria(Criteria<ItemToMatch> criteria)
        {
            this.criteria = criteria;
        }

        public bool matches(ItemToMatch item)
        {
            return !criteria.matches(item);
        }
    }
}