int CountVariants(int stairCount)
{
    if (stairCount <= 1)
        return 1;
    else if (stairCount == 2)
        return 2;
    return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
}
