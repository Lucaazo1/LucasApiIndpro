using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Indprowebbackend.DataModels
{
    public class FullContent
    {
        [Key]
        public int FullContentId { get; set; }
        public string? Header1 { get; set; }
        public string? Header2 { get; set; }
        public string? Header3 { get; set; }
        public string? Header4 { get; set; }
        public string? Header5 { get; set; }
        public int? ContentsGroup1 { get; set; }
        public int? ContentsGroup2 { get; set; }
        public int? ContentsGroup3 { get; set; }
        public int? ContentsGroup4 { get; set; }
        public int? ContentsGroup5 { get; set; }
        // All Contents from each Group:
        //Group 1:
        public string? Content1Group1 { get; set; }
        public string? SubImage1Group1 { get; set; }
        public string? ImageText1Group1 { get; set; }
        public string? SubHeader1Group1 { get; set; }

        public string? Content2Group1 { get; set; }
        public string? SubImage2Group1 { get; set; }
        public string? ImageText2Group1 { get; set; }
        public string? SubHeader2Group1 { get; set; }

        public string? Content3Group1 { get; set; }
        public string? SubImage3Group1 { get; set; }
        public string? ImageText3Group1 { get; set; }
        public string? SubHeader3Group1 { get; set; }

        public string? Content4Group1 { get; set; }
        public string? SubImage4Group1 { get; set; }
        public string? ImageText4Group1 { get; set; }
        public string? SubHeader4Group1 { get; set; }

        public string? Content5Group1 { get; set; }
        public string? SubImage5Group1 { get; set; }
        public string? ImageText5Group1 { get; set; }
        public string? SubHeader5Group1 { get; set; }

        public string? Content6Group1 { get; set; }
        public string? SubImage6Group1 { get; set; }
        public string? ImageText6Group1 { get; set; }
        public string? SubHeader6Group1 { get; set; }

        public string? Content7Group1 { get; set; }
        public string? SubImage7Group1 { get; set; }
        public string? ImageText7Group1 { get; set; }
        public string? SubHeader7Group1 { get; set; }

        public string? Content8Group1 { get; set; }
        public string? SubImage8Group1 { get; set; }
        public string? ImageText8Group1 { get; set; }
        public string? SubHeader8Group1 { get; set; }

        public string? Content9Group1 { get; set; }
        public string? SubImage9Group1 { get; set; }
        public string? ImageText9Group1 { get; set; }
        public string? SubHeader9Group1 { get; set; }

        public string? Content10Group1 { get; set; }
        public string? SubImage10Group1 { get; set; }
        public string? ImageText10Group1 { get; set; }
        public string? SubHeader10Group1 { get; set; }

        public string? Author1Group1 { get; set; }
        //Group 2:
        public string? Content1Group2 { get; set; }
        public string? SubImage1Group2 { get; set; }
        public string? ImageText1Group2 { get; set; }
        public string? SubHeader1Group2 { get; set; }

        public string? Content2Group2 { get; set; }
        public string? SubImage2Group2 { get; set; }
        public string? ImageText2Group2 { get; set; }
        public string? SubHeader2Group2 { get; set; }

        public string? Content3Group2 { get; set; }
        public string? SubImage3Group2 { get; set; }
        public string? ImageText3Group2 { get; set; }
        public string? SubHeader3Group2 { get; set; }

        public string? Content4Group2 { get; set; }
        public string? SubImage4Group2 { get; set; }
        public string? ImageText4Group2 { get; set; }
        public string? SubHeader4Group2 { get; set; }

        public string? Content5Group2 { get; set; }
        public string? SubImage5Group2 { get; set; }
        public string? ImageText5Group2 { get; set; }
        public string? SubHeader5Group2 { get; set; }

        public string? Content6Group2 { get; set; }
        public string? SubImage6Group2 { get; set; }
        public string? ImageText6Group2 { get; set; }
        public string? SubHeader6Group2 { get; set; }

        public string? Content7Group2 { get; set; }
        public string? SubImage7Group2 { get; set; }
        public string? ImageText7Group2 { get; set; }
        public string? SubHeader7Group2 { get; set; }

        public string? Content8Group2 { get; set; }
        public string? SubImage8Group2 { get; set; }
        public string? ImageText8Group2 { get; set; }
        public string? SubHeader8Group2 { get; set; }

        public string? Content9Group2 { get; set; }
        public string? SubImage9Group2 { get; set; }
        public string? ImageText9Group2 { get; set; }
        public string? SubHeader9Group2 { get; set; }

        public string? Content10Group2 { get; set; }
        public string? SubImage10Group2 { get; set; }
        public string? ImageText10Group2 { get; set; }
        public string? SubHeader10Group2 { get; set; }

        public string? Author1Group2 { get; set; }
        //Group 3:
        public string? Content1Group3 { get; set; }
        public string? SubImage1Group3 { get; set; }
        public string? ImageText1Group3 { get; set; }
        public string? SubHeader1Group3 { get; set; }

        public string? Content2Group3 { get; set; }
        public string? SubImage2Group3 { get; set; }
        public string? ImageText2Group3 { get; set; }
        public string? SubHeader2Group3 { get; set; }

        public string? Content3Group3 { get; set; }
        public string? SubImage3Group3 { get; set; }
        public string? ImageText3Group3 { get; set; }
        public string? SubHeader3Group3 { get; set; }

        public string? Content4Group3 { get; set; }
        public string? SubImage4Group3 { get; set; }
        public string? ImageText4Group3 { get; set; }
        public string? SubHeader4Group3 { get; set; }

        public string? Content5Group3 { get; set; }
        public string? SubImage5Group3 { get; set; }
        public string? ImageText5Group3 { get; set; }
        public string? SubHeader5Group3 { get; set; }

        public string? Content6Group3 { get; set; }
        public string? SubImage6Group3 { get; set; }
        public string? ImageText6Group3 { get; set; }
        public string? SubHeader6Group3 { get; set; }

        public string? Content7Group3 { get; set; }
        public string? SubImage7Group3 { get; set; }
        public string? ImageText7Group3 { get; set; }
        public string? SubHeader7Group3 { get; set; }

        public string? Content8Group3 { get; set; }
        public string? SubImage8Group3 { get; set; }
        public string? ImageText8Group3 { get; set; }
        public string? SubHeader8Group3 { get; set; }

        public string? Content9Group3 { get; set; }
        public string? SubImage9Group3 { get; set; }
        public string? ImageText9Group3 { get; set; }
        public string? SubHeader9Group3 { get; set; }

        public string? Content10Group3 { get; set; }
        public string? SubImage10Group3 { get; set; }
        public string? ImageText10Group3 { get; set; }
        public string? SubHeader10Group3 { get; set; }

        public string? Author1Group3 { get; set; }
        //Group 4:
        public string? Content1Group4 { get; set; }
        public string? SubImage1Group4 { get; set; }
        public string? ImageText1Group4 { get; set; }
        public string? SubHeader1Group4 { get; set; }

        public string? Content2Group4 { get; set; }
        public string? SubImage2Group4 { get; set; }
        public string? ImageText2Group4 { get; set; }
        public string? SubHeader2Group4 { get; set; }

        public string? Content3Group4 { get; set; }
        public string? SubImage3Group4 { get; set; }
        public string? ImageText3Group4 { get; set; }
        public string? SubHeader3Group4 { get; set; }

        public string? Content4Group4 { get; set; }
        public string? SubImage4Group4 { get; set; }
        public string? ImageText4Group4 { get; set; }
        public string? SubHeader4Group4 { get; set; }

        public string? Content5Group4 { get; set; }
        public string? SubImage5Group4 { get; set; }
        public string? ImageText5Group4 { get; set; }
        public string? SubHeader5Group4 { get; set; }

        public string? Content6Group4 { get; set; }
        public string? SubImage6Group4 { get; set; }
        public string? ImageText6Group4 { get; set; }
        public string? SubHeader6Group4 { get; set; }

        public string? Content7Group4 { get; set; }
        public string? SubImage7Group4 { get; set; }
        public string? ImageText7Group4 { get; set; }
        public string? SubHeader7Group4 { get; set; }

        public string? Content8Group4 { get; set; }
        public string? SubImage8Group4 { get; set; }
        public string? ImageText8Group4 { get; set; }
        public string? SubHeader8Group4 { get; set; }

        public string? Content9Group4 { get; set; }
        public string? SubImage9Group4 { get; set; }
        public string? ImageText9Group4 { get; set; }
        public string? SubHeader9Group4 { get; set; }

        public string? Content10Group4 { get; set; }
        public string? SubImage10Group4 { get; set; }
        public string? ImageText10Group4 { get; set; }
        public string? SubHeader10Group4 { get; set; }

        public string? Author1Group4 { get; set; }
        //Group 5:
        public string? Content1Group5 { get; set; }
        public string? SubImage1Group5 { get; set; }
        public string? ImageText1Group5 { get; set; }
        public string? SubHeader1Group5 { get; set; }

        public string? Content2Group5 { get; set; }
        public string? SubImage2Group5 { get; set; }
        public string? ImageText2Group5 { get; set; }
        public string? SubHeader2Group5 { get; set; }

        public string? Content3Group5 { get; set; }
        public string? SubImage3Group5 { get; set; }
        public string? ImageText3Group5 { get; set; }
        public string? SubHeader3Group5 { get; set; }

        public string? Content4Group5 { get; set; }
        public string? SubImage4Group5 { get; set; }
        public string? ImageText4Group5 { get; set; }
        public string? SubHeader4Group5 { get; set; }

        public string? Content5Group5 { get; set; }
        public string? SubImage5Group5 { get; set; }
        public string? ImageText5Group5 { get; set; }
        public string? SubHeader5Group5 { get; set; }

        public string? Content6Group5 { get; set; }
        public string? SubImage6Group5 { get; set; }
        public string? ImageText6Group5 { get; set; }
        public string? SubHeader6Group5 { get; set; }

        public string? Content7Group5 { get; set; }
        public string? SubImage7Group5 { get; set; }
        public string? ImageText7Group5 { get; set; }
        public string? SubHeader7Group5 { get; set; }

        public string? Content8Group5 { get; set; }
        public string? SubImage8Group5 { get; set; }
        public string? ImageText8Group5 { get; set; }
        public string? SubHeader8Group5 { get; set; }

        public string? Content9Group5 { get; set; }
        public string? SubImage9Group5 { get; set; }
        public string? ImageText9Group5 { get; set; }
        public string? SubHeader9Group5 { get; set; }

        public string? Content10Group5 { get; set; }
        public string? SubImage10Group5 { get; set; }
        public string? ImageText10Group5 { get; set; }
        public string? SubHeader10Group5 { get; set; }

        public string? Author1Group5 { get; set; }
        //Next Group?

        public string? HeaderListItem1 { get; set; }
        //här ska vi ändra
        public int? ListItemsGroup1 { get; set; }
        // All ListItems from each Group:
        public string? ListItem1Group1 { get; set; }
        public string? ListItem2Group1 { get; set; }
        public string? ListItem3Group1 { get; set; }
        public string? ListItem4Group1 { get; set; }
        public string? ListItem5Group1 { get; set; }
        public string? ListItem6Group1 { get; set; }
        public string? ListItem7Group1 { get; set; }
        public string? ListItem8Group1 { get; set; }
        public string? ListContent1Group1 { get; set; }
        //Next Group

        public string? Author { get; set; }
        public string? SubHeader1 { get; set; }
        public string? SubHeader2 { get; set; }
        public string? SubHeader3 { get; set; }
        public string? ListItems { get; set; }
        public string? ListItem1 { get; set; }
        public string? ListItem2 { get; set; }
        public string? ListItem3 { get; set; }
        public string? ListItem4 { get; set; }
        public string? ListItem5 { get; set; }
        public string? ListItem6 { get; set; }
        public string? ListItem7 { get; set; }
        public string? ListItem8 { get; set; }
    }
}
