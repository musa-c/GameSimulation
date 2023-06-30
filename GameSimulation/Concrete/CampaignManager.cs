using InterfaceAbstractExample.Abstract;
using InterfaceAbstractExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Concrete
{
    public class CampaignManager : IDbManager<Campaign>
    {
        List<Campaign> campaigns = new();
        public Campaign Create(Campaign campaign)
        {
            if(campaigns.Any(x => x.Id != campaign.Id))
            {
                campaigns.Add(campaign);
                return campaign;
            }
            else
            {
                throw new Exception("Campaign already exists!");
            }
        }

        public void Delete(int Id)
        {
            if(campaigns.Any(x => x.Id == Id))
            {
                _ = campaigns.Remove(campaigns.FirstOrDefault(x => x.Id == Id));
            }
            else
            {
                throw new Exception("Campaign not found!");
            }
        }

        public Campaign Update(int id, Campaign updatecampaign)
        {
            if (campaigns.Any(x => x.Id == id))
            {
                Campaign campaign = campaigns.FirstOrDefault(x => x.Id == id);
                campaign!.Name = "Updated Campaign";
                campaign.Percentage = "Updated Percentage";
                return campaign;
            }
            else
            {
                throw new Exception("Campaign not found!");
            }
        }
    }
}
