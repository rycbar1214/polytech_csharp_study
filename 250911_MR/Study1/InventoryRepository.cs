namespace _250911_MR.Study1;

public class InventoryRepository : IInventoryRepository
{
    //생성자로부터 IItemDataSource 와 int maxSlot (슬롯 갯수), int maxStack(아이템당 최대 갯수)를 주입받을 것
    // AddItemAsync()는 다음 규칙을 따름
        /*인벤토리에 없는 아이템을 추가할 경우 maxSlot 수를 초과할 수 없음
         하나의 아이템당 총 갯수(count)는 maxStack을 초과할 수 없음(기존 아이템에 추가할 때도 적용)
         위 조건이 모두 충족될 때만 아이템을 추가하며, 성공 시 true, 실패 시 false를 반환*/
        
        public IItemDataSource itemDataSource {get; set;}
        public int MaxSlot {get;set;}
        public int MaxStack {get;set;}
        
        private List<Item> items = new List<Item>();
        
        public InventoryRepository(IItemDataSource dataSource, int maxSlot, int maxStack)
        {
            this.itemDataSource = itemDataSource;
            MaxSlot = maxSlot;
            MaxStack = maxStack;
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Item?> GetItemByIdAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            throw new NotImplementedException();
        }
}