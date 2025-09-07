import type { AppProps } from "next/app";
import { useEffect, useState } from "react";

export default function MyApp({ Component, pageProps }: AppProps) {
    const [firstRender, setFirstRender] = useState(false);

    useEffect(() => {
        setFirstRender(true);
    }, []);

    if (firstRender) {
        return <Component {...pageProps} />;
    }

    return null;
}
