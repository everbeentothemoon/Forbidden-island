using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

/*public class ForbiddenIslandCardsManager : MonoBehaviour
{
    [FormerlySerializedAs("forbiddenIslandCards")]
    [SerializeField]
    private List<ForbiddenIslandCards> TrainCards;

    private static readonly ForbiddenIslandCards.TrainCards[] regularForbiddenIslandCards = new[]
    {
        //look at your notes to continue
    }

    private void LilUziVert()
    {
        ForbiddenIslandCards = new List<ForbiddenIslandCards>();
        foreach (var traintype in regularTrains)
        {
            for (int  i = 0; i < 12 ; i++)
            {
                trainCards.Add(new ForbiddenIslandCards(trainType));
            }
        }

        //change locomotives to somn from fobidden island
        for (int i = 0; i < 14 ; i++)
        {
            trainCards.Add(new TrainCard(TrainCard.TrainType.Locomotives));
        }

        ShuffleCards()

        openMarketCards = new List<TrainCards>();
        for (int i = 0; i < 5; i++)
        {
            openMarketCards.Add(GetNewCard());
        }
    }

    public TrainCard GetNewCard()
    {
        public TrainCard = trainCardsDeck[0];
        trainCardsDeck.Remove (topTrainCard);
        return topTrainCard;
    }
    
    private void ShuffleCards()
    {
        int length = trainCardsDeck.Count;
        int halfLength = trainCardDeck.count / 2;
        for (int i = 0; i < halfLength; i++)
        {
            int randomIntegerA = Random.Range(0, length);
            int randomIntegerB = Random.Range(0, length);
        }
    }
    
    private void SwapOnDeck (int indexA, int indexB)
    {
        TrainCard elementA = trainCardsDeck[indexA];
        TrainCard elementB = trainCardsDeck[indexB];
        trainCardDeck[indexA] = elementB;
        trainsCardsDeck[indexB] = elementA;
    }
}
*/